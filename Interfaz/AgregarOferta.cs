using Modelos;
using Negocio;
using Negocios;
using System.Data;

namespace Interfaz
{
    public partial class AgregarOferta : Form
    {
        private List<Usuario> usuarios = new();
        public AgregarOferta()
        {
            InitializeComponent();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private async void AgregarOferta_Load(object sender, EventArgs e)
        {
            await CargarEncargadosAsync();
        }
        private async Task CargarEncargadosAsync()
        {
            try
            {
                UsuarioNegocio UsuarioNegocio = new();
                usuarios = await UsuarioNegocio.ListarVendedoresAsync();
                foreach (var item in usuarios)
                {
                    cbEncargado.Items.Add(item.Nombre);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error Interno: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            bool valido = ValidarCampos();
            if (valido)
            {
                Oferta ofertaTemporal = new();
                ofertaTemporal.AutorPrespuesto = Temporal.UsuarioActivo.Nombre;
                ofertaTemporal.UltimaModificacion = DateTime.Now;
                ofertaTemporal.Fecha = dateTimePickerFecha.Value;
                ofertaTemporal.Cliente = txtCliente.Text;
                float.TryParse(txtMonto.Text, out float tmpNumero);
                ofertaTemporal.Monto = tmpNumero;
                ofertaTemporal.Notas = txtNotas.Text;
                ofertaTemporal.DDCE = checkBoxDDCE.Checked;
                ofertaTemporal.Ionizante = checkBoxIonizante.Checked;
                ofertaTemporal.Supresor = checkBoxSupresor.Checked;
                ofertaTemporal.Torre = checkBoxTorre.Checked;
                ofertaTemporal.Malla = checkBoxMalla.Checked;
                ofertaTemporal.Otros = checkBoxOtro.Checked;
                ofertaTemporal.Provincia = comboBoxProvincia.Text;
                ofertaTemporal.Categoria = comboBoxCategoria.Text;
                ofertaTemporal.Observaciones = txtObservaciones.Text;
                ofertaTemporal.UsuarioId = (from i in usuarios
                                            where i.Nombre == cbEncargado.Text
                                            select i.UsuarioId).FirstOrDefault();
                ofertaTemporal.EncargadoCotizador = txtEncargado.Text;
                OfertaNegocio negocioOferta = new();
                bool Resultado = negocioOferta.CrearOferta(ofertaTemporal, out int idOferta);
                if (Resultado)
                {
                    MessageBox.Show($"Oferta Guardada exitosamente \n\nOferta Id= {idOferta}\nCliente= {ofertaTemporal.Cliente}\nMonto= {ofertaTemporal.Monto}", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {
                    MessageBox.Show($"Error interno, no fue posible guardar la información", "Error interno", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        /// <summary>
        /// Valida la verificación realizada a los campos del formulario
        /// </summary>
        /// <returns>True si es válido, False si presenta error</returns>
        private bool ValidarCampos()
        {
            try
            {
                if (string.IsNullOrEmpty(txtCliente.Text))
                {
                    MessageBox.Show($"Nombre del Cliente no digitado", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }
                int.TryParse(txtMonto.Text, out int val);
                if (val == 0)
                {
                    var resultado = MessageBox.Show($"Monto No digitado\n¿Desea continuar?", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (resultado != DialogResult.Yes)
                    {
                        return false;
                    }
                }
                if (string.IsNullOrEmpty(txtNotas.Text))
                {
                    var resultado = MessageBox.Show($"Notas de la cotización se encuentra vacío\n¿Desea continuar?", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (resultado == DialogResult.Yes)
                    {
                    }
                    else
                    {
                        return false;
                    }
                }

                if (string.IsNullOrEmpty(comboBoxProvincia.Text))
                {
                    MessageBox.Show($"Provincia no Selecionada", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }
                if (string.IsNullOrEmpty(comboBoxCategoria.Text))
                {
                    MessageBox.Show($"Categoria no seleccionada", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }

                if (string.IsNullOrEmpty(txtObservaciones.Text))
                {
                    MessageBox.Show("Descripción del trabajo no mencionada", "Adventencia", MessageBoxButtons.OK);
                }
                if (string.IsNullOrEmpty(cbEncargado.Text))
                {
                    MessageBox.Show($"No seleccionó un vendedor", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }
                if (string.IsNullOrEmpty(txtEncargado.Text))
                {
                    MessageBox.Show($"No ingreso un encargado de la realización de la cotización", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error interno\n{ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
                return false;
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
