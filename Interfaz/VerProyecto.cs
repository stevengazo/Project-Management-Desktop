using Modelos;
using Negocios;
using System.Data;
using System.Globalization;

namespace Interfaz
{
    public partial class VerProyecto : Form
    {
        public int idProyecto { get; set; } = 0;
        public VerProyecto()
        {
            InitializeComponent();
        }

        private void VerProyecto_Load(object sender, EventArgs e)
        {
            CargarProyectoDetallado();
        }

        private void CargarProyectoBasico()
        {
            if (idProyecto == 0)
            {
                MessageBox.Show("Error interno, no hay un proyecto especificado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {

            }

        }

        private void CargarNotas( List<Nota> notas )
        {
            dataGridViewComentarios.Columns.Clear();
            DataTable _table = new();
            _table.Columns.Add("Titulo Comentario");
            foreach (Nota nota in notas )
            {
                _table.Rows.Add(nota.Titulo);
            }
            DataGridViewButtonColumn btnVer = new();
            btnVer.HeaderText = "Ver";
            btnVer.Text = "Ver";
            btnVer.UseColumnTextForButtonValue = true;
            dataGridViewComentarios.Columns.Add(btnVer);

        }
        private void CargarProyectoDetallado()
        {
            try
            {
                if (idProyecto == 0)
                {
                    MessageBox.Show("Error interno, no hay un proyecto especificado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    ProyectoNegocios proyectoNegocios = new();
                    Proyecto proyectoTemporal = proyectoNegocios.ObtenerProyecto(idProyecto);
                    txtNumeroProyecto.Text = $"P-{proyectoTemporal.ProyectoId.ToString()}";
                    txtEstado.Text = proyectoTemporal.Estado;
                    txtVendedor.Text = proyectoTemporal.Vendedor.Nombre;
                    txtRazonSocial.Text = proyectoTemporal.Cliente;
                    txtOC.Text = proyectoTemporal.FechaOC.ToLongDateString();
                    txtContacto.Text = proyectoTemporal.Contacto;
                    txtOferta.Text = proyectoTemporal.OfertaId;
                    txtMontoProyecto.Text = proyectoTemporal.Monto.ToString("C", CultureInfo.CurrentCulture);
                    txtPorcentaje.Text = $"{proyectoTemporal.PorcentajeAnticipo}%";
                    txtNumeroFacturaAnticipo.Text = proyectoTemporal.FacturaAnticipoId;
                    txtNumeroTarea.Text = proyectoTemporal.TareaId.ToString();
                    txtUbicacion.Text = proyectoTemporal.Ubicacion;
                    txtNotas.Text = proyectoTemporal.Tipo;
                    txtFechaInicio.Text = proyectoTemporal.FechaInicio.ToLongDateString();
                    txtFechaFinal.Text = proyectoTemporal.FechaFinal.ToLongDateString();

                }
            }
            catch (Exception f)
            {
                MessageBox.Show($"Error interno: {f.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }


        }
    }
}
