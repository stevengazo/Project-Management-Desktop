using Modelos;
using Negocio;
using Negocios;
using System.Data;

namespace Interfaz
{
    public partial class EditarOferta : Form
    {
        public int idOferta { get; set; } = -1;
        private List<Usuario> usuarios;
        private Oferta Ofertatmp;
        public EditarOferta()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            try
            {
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error interno: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        }
        private bool ValidarCampos()
        {
            try
            {
                if (string.IsNullOrEmpty(txtCliente.Text))
                {
                    MessageBox.Show($"Nombre del Cliente no digitado", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }

                if (numericUpDownMonto.Value == 0)
                {
                    var resultado = MessageBox.Show($"Monto No digitado\n¿Desea continuar?", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (resultado == DialogResult.Yes)
                    {

                    }
                    else
                    {
                        return false;
                    }
                }
                if (string.IsNullOrEmpty(txtNotas.Text))
                {
                    var resultado = MessageBox.Show($"Monto notas de la cotización\n¿Desea continuar?", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (resultado == DialogResult.Yes)
                    {

                    }
                    else
                    {
                        return false;
                    }
                }
                if (string.IsNullOrEmpty(txtObservaciones.Text))
                {
                    MessageBox.Show("Descripcion del trabajo no mencionada", "Adventencia", MessageBoxButtons.OK);
                }
                if (string.IsNullOrEmpty(cbEncargado.Text))
                {
                    MessageBox.Show($"No selecciono un vendedor", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }
                if (string.IsNullOrEmpty(txtEncargado.Text))
                {
                    MessageBox.Show($"No ingreso un encargado de la realizacion de la cotizacion", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
                return false;
            }
        }

        private void EditarOferta_Load(object sender, EventArgs e)
        {
            try
            {
                OfertaNegocio ofertaNegocio = new();
                Ofertatmp = ofertaNegocio.ObtenerOferta(idOferta);
                if (Temporal.TipoLogin.Equals("Administrador") || Ofertatmp.UsuarioId == Temporal.UsuarioActivo.UsuarioId)
                {
                    UsuarioNegocio tmpNegocioUsuario = new();
                    usuarios = tmpNegocioUsuario.ListarVendedores().Distinct().ToList();
                    foreach (var item in usuarios)
                    {
                        cbEncargado.Items.Add(item.Nombre);
                    }
                    if (idOferta != -1)
                    {
                        if (Ofertatmp == null)
                        {
                            MessageBox.Show($"Error interno: el id de oferta no fue especificado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            this.Close();
                        }
                        else
                        {
                            dateTimePickerFecha.Value = Ofertatmp.Fecha;
                            txtCliente.Text = Ofertatmp.Cliente;
                            numericUpDownMonto.Value = (decimal)Ofertatmp.Monto;
                            comboBoxMedio.Text = Ofertatmp.MedioContacto;
                            comboBoxEstado.Text = Ofertatmp.Estado;
                            txtNotas.Text = Ofertatmp.Notas;
                            checkBoxDDCE.Checked = Ofertatmp.DDCE;
                            checkBoxIonizante.Checked = Ofertatmp.Ionizante;
                            checkBoxSupresor.Checked = Ofertatmp.Supresor;
                            checkBoxTorre.Checked = Ofertatmp.Torre;
                            checkBoxMalla.Checked = Ofertatmp.Malla;
                            numericUpDownTarea.Value = (decimal)Ofertatmp.TareaId;
                            checkBoxOtro.Checked = Ofertatmp.Otros;
                            comboBoxCategoria.Text = Ofertatmp.Categoria;
                            comboBoxProvincia.Text = Ofertatmp.Provincia;
                            txtObservaciones.Text = Ofertatmp.Observaciones;
                            cbEncargado.SelectedText = Ofertatmp.Encargado.Nombre;
                            txtEncargado.Text = Ofertatmp.EncargadoCotizador;
                        }
                    }
                    else
                    {
                        MessageBox.Show($"Error interno: el id de oferta no fue especificado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        this.Close();
                    }
                }
                else
                {
                    MessageBox.Show($"Esta Funcionabilidad solo se encuentra disponible para los Administradores\nContacte con algún administrador para realizar el cambio", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error interno: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                bool valido = ValidarCampos();
                if (valido)
                {
                    Ofertatmp.AutorPrespuesto = Temporal.UsuarioActivo.Nombre;
                    Ofertatmp.UltimaModificacion = DateTime.Now;
                    Ofertatmp.Fecha = dateTimePickerFecha.Value;
                    Ofertatmp.Cliente = txtCliente.Text;
                    Ofertatmp.Monto = (float)numericUpDownMonto.Value;
                    Ofertatmp.Notas = txtNotas.Text;
                    Ofertatmp.Observaciones = txtObservaciones.Text;
                    Ofertatmp.UsuarioId = (from i in usuarios
                                           where i.Nombre == cbEncargado.Text
                                           select i.UsuarioId).FirstOrDefault();
                    Ofertatmp.Encargado = null;
                    Ofertatmp.EncargadoCotizador = txtEncargado.Text;
                    Ofertatmp.DDCE = checkBoxDDCE.Checked;
                    Ofertatmp.Ionizante = checkBoxIonizante.Checked;
                    Ofertatmp.Supresor = checkBoxSupresor.Checked;
                    Ofertatmp.Torre = checkBoxTorre.Checked;
                    Ofertatmp.Malla = checkBoxMalla.Checked;
                    Ofertatmp.Otros = checkBoxOtro.Checked;
                    Ofertatmp.MedioContacto = comboBoxMedio.Text;
                    Ofertatmp.Estado = comboBoxEstado.Text;
                    Ofertatmp.TareaId = (int)numericUpDownTarea.Value;
                    Ofertatmp.Concluida = (comboBoxEstado.Text == "Cobro") ? true : false;
                    Ofertatmp.Categoria = comboBoxCategoria.Text;
                    Ofertatmp.Provincia = comboBoxProvincia.Text;

                    OfertaNegocio negocioOferta = new();
                    bool Resultado = negocioOferta.ActualizarOferta(Ofertatmp, out int idOferta);
                    if (Resultado)
                    {
                        MessageBox.Show($"Oferta Actualizada exitosamente \n\nOferta Id= {idOferta}\nCliente= {Ofertatmp.Cliente}\nMonto= {Ofertatmp.Monto}", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show($"Error interno, no fue posible guardar la información", "Error interno", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error interno, no fue posible guardar la informacion. {ex.Message}", "Error interno", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void label12_Click(object sender, EventArgs e)
        {

        }
    }
}
