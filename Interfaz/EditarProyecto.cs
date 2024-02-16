using Modelos;
using Negocio;
using Negocios;
using System.Data;

namespace Interfaz
{
    public partial class EditarProyecto : Form
    {
        #region Propiedades
        private List<Usuario> Vendedores = new();
        private Dictionary<int, string> Ofertas = new();
        private Proyecto ProyectoActual { get; set; }
        public int ProyectoId { get; set; } = 0;
        #endregion

        #region Constructor
        public EditarProyecto()
        {
            try
            {
                InitializeComponent();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error interno - {ex.Message}", $"Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        }
        #endregion

        #region Metodos

        /// <summary>
        /// Carga los vendedores existentes en el combobox
        /// </summary>
        private void CargarVendedores()
        {
            UsuarioNegocio usuarioNegocio = new();
            Vendedores = usuarioNegocio.ListarVendedores();
            if (Vendedores.Count > 0)
            {
                comboBoxVendedores.Items.Clear();
                foreach (var item in Vendedores)
                {
                    comboBoxVendedores.Items.Add(item.Nombre);
                }
            }
        }



        /// <summary>
        /// Funcion de Borrado
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnBorrar_Click(object sender, EventArgs e)
        {
            var Resultado = MessageBox.Show("¿Deseas borrar este ProyectoActual?", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (Resultado == DialogResult.Yes)
            {
                ProyectoNegocios proyectoNegocios = new();
                var resultado1 = proyectoNegocios.DesactivarProyecto(ProyectoActual.ProyectoId);
                if (resultado1)
                {
                    MessageBox.Show("Proyecto Desactivado \nEste proyecto no se encontrará visible para los usuarios \nPara volver a activarlo contacte con el administrador de la DB", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
            }
        }

        /// <summary>
        /// Carga la información del proyecto
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void EditarProyecto_Load(object sender, EventArgs e)
        {
            try
            {
                if (ProyectoId != 0)
                {
                    CargarVendedores();

                    ProyectoNegocios proyectoNegocios = new();
                    ProyectoActual = proyectoNegocios.ObtenerProyecto(ProyectoId);
                    txtidProyecto.Text = $"P-{ProyectoActual.ProyectoId.ToString()}";
                    txtRazonSocial.Text = ProyectoActual.Cliente;
                    txtCedula.Text = ProyectoActual.Cedula;
                    checkBoxPublico.Checked = ProyectoActual.EsPublico;
                    numericUpDownOfertaID.Value = decimal.Parse(ProyectoActual.OfertaId.ToString());
                    txtOrdenCompra.Text = ProyectoActual.OrdenCompra;
                    dtpOrdenCompra.Value = ProyectoActual.FechaOC;
                    comboBoxTipoMoneda.Text = ProyectoActual.TipoMoneda;
                    numericUpDownMonto.Value = decimal.Parse(ProyectoActual.Monto.ToString());
                    numericUpDownMontoIVA.Value = decimal.Parse(ProyectoActual.MontoIVA.ToString());
                    numericUpDownPorcentaje.Value = ProyectoActual.PorcentajeAnticipo;
                    txtDescripcion.Text = ProyectoActual.Descripcion;
                    txtUbicacion.Text = ProyectoActual.Ubicacion;
                    numericUpDownTarea.Value = decimal.Parse(ProyectoActual.TareaId.ToString());
                    cbTipoTrabajo.Text = ProyectoActual.Tipo;
                    cbProvincia.Text = ProyectoActual.Provincia;
                    var nombre = ProyectoActual.Vendedor.Nombre.ToString();
                    comboBoxVendedores.Text = nombre;
                    cbEstado.Text = ProyectoActual.Estado;

                }
                else
                {
                    MessageBox.Show("Error interno", "Advertencia");
                    this.Close();
                }
            }
            catch (Exception egt)
            {
                MessageBox.Show($"Error interno: {egt.Message}", "Advertencia");
            }


        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                bool Valido = ValidarDatos();
                if (Valido)
                {
                    ProyectoNegocios proyectoNegocios = new();
                    if (ProyectoActual != null)
                    {


                        ProyectoActual.Cliente = txtRazonSocial.Text;
                        ProyectoActual.Cedula = txtCedula.Text;
                        ProyectoActual.EsPublico = checkBoxPublico.Checked;
                        ProyectoActual.OfertaId = numericUpDownOfertaID.Text;
                        ProyectoActual.OrdenCompra = txtOrdenCompra.Text;
                        ProyectoActual.FechaOC = dtpOrdenCompra.Value;
                        ProyectoActual.TipoMoneda = comboBoxTipoMoneda.Text;
                        ProyectoActual.Monto = (float)numericUpDownMonto.Value;
                        ProyectoActual.MontoIVA = (int)numericUpDownMontoIVA.Value;
                        ProyectoActual.PorcentajeAnticipo = (int)numericUpDownPorcentaje.Value;
                        ProyectoActual.TipoCambio = (float)numericUpDownTipoCambio.Value;
                        ProyectoActual.Tipo = cbTipoTrabajo.Text;
                        ProyectoActual.Descripcion = txtDescripcion.Text;
                        ProyectoActual.Provincia = cbProvincia.Text;
                        ProyectoActual.Ubicacion = txtUbicacion.Text;
                        ProyectoActual.TareaId = (int)numericUpDownTarea.Value;
                        ProyectoActual.Vendedor = null;
                        ProyectoActual.UsuarioId = (from v in Vendedores
                                                    where v.Nombre == comboBoxVendedores.Text
                                                    select v.UsuarioId).FirstOrDefault();
                        ProyectoActual.Estado = cbEstado.Text;
                        ProyectoActual.Finalizado = (cbEstado.Text == "Finalizado sin cobro" ) ? true : false;

                        // Metadata
                        ProyectoActual.UltimoEditor = Temporal.UsuarioActivo.Nombre;
                        ProyectoActual.UltimaEdicion = DateTime.Now;
                        ProyectoActual.Provincia = cbProvincia.Text;
                        ProyectoActual.Tipo = cbTipoTrabajo.Text;


                        bool resultado = proyectoNegocios.ActualizarProyecto(ProyectoActual);
                        if (resultado)
                        {
                            MessageBox.Show("Proyecto Actualizado", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("No fue posible actualizar la ", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Close();
                        }
                    }
                }
            }
            catch (Exception f)
            {
                MessageBox.Show($"Error interno: {f.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }

        }

        /// <summary>
        /// Valida los datos del proyecto
        /// </summary>
        /// <returns>True si no presenta error, false si hay algún inconventiente</returns>
        private bool ValidarDatos()
        {
            try
            {
                if (string.IsNullOrEmpty(txtRazonSocial.Text))
                {
                    MessageBox.Show("No ha digitado una razón social o nombre del cliente", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }
                if (string.IsNullOrEmpty(txtUbicacion.Text))
                {
                    MessageBox.Show("No digito la ubicación del ProyectoActual", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                string datos = cbEstado.Text;
                if (string.IsNullOrEmpty(datos))
                {
                    MessageBox.Show("Estado del ProyectoActual no seleccionado", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }
                return true;
            }
            catch (Exception t)
            {
                MessageBox.Show($"Error interno: {t.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
                return false;
            }
        }

        #endregion

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }
    }
}
