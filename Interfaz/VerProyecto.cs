using Modelos;
using Negocios;
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
                    txtMontoProyecto.Text = proyectoTemporal.Monto.ToString("C", CultureInfo.GetCultureInfo("es-cr"));
                    txtPorcentaje.Text = $"{proyectoTemporal.PorcentajeAnticipo}%";
                    txtNumeroFacturaAnticipo.Text = proyectoTemporal.FacturaAnticipoId;
                    txtNumeroTarea.Text = proyectoTemporal.TareaId.ToString();
                    txtUbicacion.Text = proyectoTemporal.Ubicacion;
                    txtNotas.Text = proyectoTemporal.Notas;
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
