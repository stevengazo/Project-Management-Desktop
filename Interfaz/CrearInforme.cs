using Modelos;
using Negocio;
using Negocios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Interfaz
{
    public partial class CrearInforme : Form
    {
        public CrearInforme()
        {
            InitializeComponent();
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(comboBoxEstado.Text) || string.IsNullOrEmpty(txtDescripcion.Text))
            {
                MessageBox.Show("Los campos se encuentran vacios", "Información", MessageBoxButtons.OK, MessageBoxIcon.Question);

            }
            else{
                Informe nuevoInforme = new Informe();
                nuevoInforme.UltimaModificacion = DateTime.Now;
                nuevoInforme.UltimoEditor = Temporal.UsuarioActivo.Nombre;
                nuevoInforme.Tecnico = (!string.IsNullOrEmpty(txtTecnico.Text)) ? "No Indicado" : txtTecnico.Text;
                nuevoInforme.Calificacion = 1;
                nuevoInforme.FechaMaxima = dateTimePickerEntrega.Value;
                nuevoInforme.Comentarios = "";
                nuevoInforme.Concluido = false;
                nuevoInforme.FechaRegistro = DateTime.Now;
                nuevoInforme.ProyectoId = int.Parse(comboBoxProyectoId.Text);
                nuevoInforme.Estado = "Pendiente";
                nuevoInforme.Descripcion = txtDescripcion.Text;
                InformeNegocio.Add(nuevoInforme);
                MessageBox.Show("Informe Agregado", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
        }

        private void CrearInforme_Load(object sender, EventArgs e)
        {
            ProyectoNegocios pN = new ProyectoNegocios();
            var da = pN.ArregloIds();
            foreach (var item in da)
            {
                comboBoxProyectoId.Items.Add(item);
            }
        }
    }
}
