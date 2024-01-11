using Negocio;
using System.Globalization;

namespace Interfaz
{
    public partial class VerOferta : Form
    {
        public int idOferta { get; set; }
        public VerOferta()
        {
            InitializeComponent();
        }

        private void VerOferta_Load(object sender, EventArgs e)
        {
            OfertaNegocio ofertaNegocio = new();
            var oferta = ofertaNegocio.ObtenerOferta(idOferta);
            if (oferta != null)
            {
                txtCliente.Text = oferta.Cliente;
                txtFecha.Text = oferta.Fecha.ToLongDateString();

                txtMonto.Text = oferta.Monto.ToString("C", CultureInfo.CurrentCulture);
                txtNotas.Text = oferta.Notas;

                checkBoxDDCE.Checked = oferta.DDCE;
                checkBoxIonizante.Checked = oferta.Ionizante;
                checkBoxMalla.Checked = oferta.Malla;
                checkBoxOtro.Checked = oferta.Otros;
                checkBoxSupresor.Checked = oferta.Supresor;
                checkBoxTorre.Checked = oferta.Torre;
                textBoxProvincia.Text = oferta.Provincia;
                textBoxCategoria.Text = oferta.Categoria;
                txtObservaciones.Text = oferta.Observaciones;
                textEncargado.Text = oferta.Encargado.Nombre;
                txtCotizador.Text = oferta.EncargadoCotizador;
            }
            else
            {
                MessageBox.Show("Error no es posible mostrar la oferta", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        }
    }
}
