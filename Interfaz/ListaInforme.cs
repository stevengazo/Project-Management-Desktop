using Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Modelos;
using Negocios;

namespace Interfaz
{
    public partial class ListaInforme : Form
    {
        private Thread CargarInformes;
        private Informe informe = new();
        public ListaInforme()
        {
            InitializeComponent();

        }

        private void ListaInforme_Load(object sender, EventArgs e)
        {
            UsuarioNegocio usuarioNegocio = new UsuarioNegocio();
            var autores = usuarioNegocio.ListarUsuarios();

            foreach (var item in autores)
            {
                comboBoxAutor.Items.Add(item.Nombre);
            }
            CargarTabla();
        }

        private void CargarTabla()
        {
            if (CargarInformes == null || CargarInformes.ThreadState == ThreadState.Stopped)
            {
                CargarInformes = new Thread(new ThreadStart(() =>
                {
                    dataGridViewInformes.Invoke(new Action(() =>
                    {
                        var informes = InformeNegocio.GetList(DateTime.Today.AddYears(-4).Year);
                        if (informes != null)
                        {
                            DataTable dt = new DataTable();
                            dt.Columns.Add("Id");
                            dt.Columns.Add("Cliente");
                            dt.Columns.Add("ID Proyecto");
                            dt.Columns.Add("Tipo Informe");
                            dt.Columns.Add("Estado");
                            dt.Columns.Add("Fecha Finalizacion");
                            dt.Columns.Add("Técnico");
                            dt.Columns.Add("Calificación");
                            dt.Columns.Add("Autor");
                            dt.Columns.Add("Descripción");
                            foreach (var item in informes)
                            {
                                dt.Rows.Add(
                                      item.InformeId,
                                      item.Proyecto.Cliente,
                                      item.ProyectoId,
                                      item.Proyecto.Tipo,
                                      item.Estado,
                                      (item.Concluido) ? item.FechaRegistro.ToLongDateString() : "Sin Finalizar",
                                      item.Tecnico,
                                      item.Calificacion,
                                      (item.Usuario != null) ? item.Usuario.Nombre : "No Asignado",
                                      (item.Descripcion.Length > 20) ? $"{String.Join("", item.Descripcion.Take(20))}..." : item.Descripcion
                                    );
                            }
                            dataGridViewInformes.DataSource = dt;
                        }
                    }));
                }));
                CargarInformes.Start();
            }
        }

        private void informesPendientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InformesPendientes informesPendientes = new();
            informesPendientes.Show();
        }

        private void crearInformeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CrearInforme crearInforme = new();
            crearInforme.Show();
            CargarTabla();
        }

        private void dataGridViewInformes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int row = e.RowIndex;
                var id = int.Parse(dataGridViewInformes.Rows[row].Cells[0].Value.ToString());
                informe = InformeNegocio.GetById(id);
                txtIdInforme.Text = informe.InformeId.ToString();
                comboBoxEstado.Text = informe.Estado;
                comboBoxAutor.Text = (informe.Usuario != null) ? informe.Usuario.Nombre : "";
                txtComentarios.Text = informe.Comentarios;
                txtTecnico.Text = informe.Tecnico;
                trackBarCalificacion.Value = informe.Calificacion;
                txtComentarios.Text = informe.Comentarios;
                txtDescripcion.Text = informe.Descripcion;
                dateTimePickerEntrega.Value = informe.FechaMaxima;
                dateTimePickerFinalizacion.Value = informe.FechaRegistro;
            }
            catch (Exception j)
            {


            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            try
            {
                informe.Estado = comboBoxEstado.Text;
                // set the conclude report
                informe.Concluido = (comboBoxEstado.Text.ToLower().Equals("finalizado")) ? true : false;
                UsuarioNegocio usuarioNegocio = new();
                // get user id
                var id = usuarioNegocio.GetIdByName(comboBoxAutor.Text);
                informe.UsuarioId = (id != 0) ? id : null;

                informe.Comentarios = txtComentarios.Text;
                informe.Tecnico = txtTecnico.Text;
                informe.Usuario = null;
                informe.Descripcion = txtDescripcion.Text;
                informe.Calificacion = trackBarCalificacion.Value;
                informe.FechaMaxima = dateTimePickerEntrega.Value;
                informe.FechaRegistro = dateTimePickerFinalizacion.Value;
                InformeNegocio.Update(informe);
                MessageBox.Show("Informe actualizado", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception f)
            {

            }
            finally
            {
                CargarTabla();
            }
        }
    }
}
