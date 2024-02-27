using Modelos;
using Negocio;
using Negocios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Interfaz
{
    public partial class InformesPendientes : Form
    {
        private Informe informe;
        private Thread HiloInformes;

        public InformesPendientes()
        {
            InitializeComponent();
            cargar();
        }

        private void cargar()
        {
            UsuarioNegocio usuarioNegocio = new UsuarioNegocio();
            var us = usuarioNegocio.ListarAsistentes();
            foreach (var item in us)
            {
                comboBoxAutor.Items.Add(item.Nombre);
            }
        }

        private void Creacion()
        {
            if (HiloInformes == null || HiloInformes.ThreadState == ThreadState.Stopped)
            {
                HiloInformes = new Thread(new ThreadStart(() =>
                {
                    dataGridViewPendientes.Invoke(new Action(() =>
                    {
                        var Informes = InformeNegocio.ListUnfinished();
                        if (Informes != null)
                        {
                            DataTable dt = new DataTable();
                            dt.Columns.Add("Id");
                            dt.Columns.Add(" Entrega Maxima");
                            dt.Columns.Add("Cliente");
                            dt.Columns.Add("Proyecto Id");
                            dt.Columns.Add("Tarea");
                            dt.Columns.Add("Tipo Trabajo");
                            dt.Columns.Add("Técnico");
                            dt.Columns.Add("Encargado");
                            dt.Columns.Add("Estado");
                            foreach (var item in Informes)
                            {
                                dt.Rows.Add(
                                    item.InformeId,
                                    item.FechaMaxima.ToLongDateString(),
                                    item.Proyecto.Cliente,
                                    item.ProyectoId,
                                    item.Proyecto.TareaId,
                                    item.Proyecto.Tipo,
                                    (string.IsNullOrEmpty(item.Tecnico)) ? "Sin Dato" : item.Tecnico,
                                    (item.Usuario != null) ? item.Usuario.Nombre : "Sin Asignar",
                                    item.Estado

                                    );;
                            }
                            dataGridViewPendientes.DataSource = dt;
                        }
                    }));
                }));
                HiloInformes.Start();
            }

        }

        private void InformesPendientes_Load(object sender, EventArgs e)
        {
            Creacion();
        }

        private void dataGridViewPendientes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int row = e.RowIndex;
                var id = int.Parse(dataGridViewPendientes.Rows[row].Cells[0].Value.ToString());
                informe = InformeNegocio.GetById(id);
                txtIdInforme.Text = informe.InformeId.ToString();
                comboBoxEstado.Text = informe.Estado;
                comboBoxAutor.Text = (informe.Usuario != null) ? informe.Usuario.Nombre : "";
                txtTecnico.Text = informe.Tecnico;
            }
            catch (Exception j)
            {

            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtTecnico.Text) || string.IsNullOrEmpty(comboBoxAutor.Text) || string.IsNullOrEmpty(comboBoxEstado.Text) )
            {
                MessageBox.Show("La información requerida esta vacia", "Información");
            }
            else
            {
                informe.Concluido = (comboBoxEstado.Text.ToLower().Equals("finalizado")) ? true : false;
                informe.Estado = comboBoxEstado.Text;
                UsuarioNegocio usuarioNegocio = new();
                // get user id
                var id = usuarioNegocio.GetIdByName(comboBoxAutor.Text);
                informe.Usuario = null;
                informe.UsuarioId = (id != 0) ? id : null;
                informe.Tecnico = txtTecnico.Text;
                informe.UltimaModificacion = DateTime.Now;
                informe.UltimoEditor = Temporal.UsuarioActivo.Nombre;
                InformeNegocio.Update(informe);
                MessageBox.Show("Informe Actualizado", "Información");
                Creacion();
            }
        }
    }
}
