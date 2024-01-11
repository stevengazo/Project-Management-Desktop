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
            bool Exist = Vendedores.Exists(D => D.UsuarioId == ProyectoActual.UsuarioId);
            if (!Exist)
            {
                Vendedores.Add(ProyectoActual.Vendedor);
            }
            if (Vendedores.Count > 0)
            {
                cbVendedores.Items.Clear();
                foreach (var item in Vendedores)
                {
                    cbVendedores.Items.Add(item.Nombre);
                }

            }
        }

        /// <summary>
        /// Carga la lista de Ofertas en el combo box
        /// </summary>
        /// <returns></returns>
        private async Task cargarOfertas()
        {
            try
            {
                OfertaNegocio ofertaNegocio = new();
                Ofertas = await ofertaNegocio.DiccionarioOfertasAsync();
                if (Ofertas != null)
                {
                    comboBoxOfertas.Items.Clear();
                    comboBoxOfertas.Items.Add($"1-No asignado / No Asignado");
                    foreach (var item in Ofertas)
                    {
                        comboBoxOfertas.Items.Add($"{item.Key}-{item.Value}");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
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
                    ProyectoNegocios proyectoNegocios = new();
                    ProyectoActual = proyectoNegocios.ObtenerProyecto(ProyectoId);
                    txtidProyecto.Text = $"P-{ProyectoActual.ProyectoId.ToString()}";
                    // vendedor
                    cbVendedores.Text = ProyectoActual.Vendedor.Nombre;
                    txtRazonSocial.Text = ProyectoActual.Cliente;
                    dtpOC.Value = ProyectoActual.FechaOC;
                    txtContacto.Text = ProyectoActual.Cliente;
                    // oferta
                    bool tryOferta = int.TryParse(ProyectoActual.OfertaId, out int idOferta);
                    if (tryOferta)
                    {
                        var ofertaIdTemporal = int.Parse(ProyectoActual.OfertaId);
                        OfertaNegocio ofertaNegocio = new();
                        var oferta = ofertaNegocio.ObtenerOferta(idOferta);
                        comboBoxOfertas.Text = (oferta == null) ? $"1-No Asignado/No Disponible" : $"{oferta.OfertaId}-{oferta.Cliente}";

                    }
                    else
                    {
                        MessageBox.Show($"Error interno, el valor de {nameof(ProyectoActual.OfertaId)}, no es valido, contacta a un administrador", "Advertencia");
                        comboBoxOfertas.Text = "1 - No Valido ";
                    }


                    txtMonto.Text = ProyectoActual.Monto.ToString();
                    numericUpDownPorcentaje.Value = ProyectoActual.PorcentajeAnticipo;
                    txtNumeroFacturaAnticipo.Text = ProyectoActual.FacturaAnticipoId;
                    txtTarea.Text = ProyectoActual.TareaId.ToString();
                    txtFacturalFinalId.Text = ProyectoActual.FacturaFinalId;
                    txtUbicacion.Text = ProyectoActual.Ubicacion;
                    dtpInicio.Value = ProyectoActual.FechaInicio;
                    dtpFinalizacion.Value = ProyectoActual.FechaFinal;
                    cbEstado.Text = ProyectoActual.Estado;
                    await cargarOfertas();
                    CargarVendedores();
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
                        ProyectoActual.UsuarioId = (from v in Vendedores
                                                    where v.Nombre == cbVendedores.Text
                                                    select v.UsuarioId).FirstOrDefault();
                        ProyectoActual.Cliente = txtRazonSocial.Text;
                        ProyectoActual.FechaOC = dtpOC.Value;
                        ProyectoActual.Contacto = txtContacto.Text;
                        var oferta = comboBoxOfertas.Text.Split('-');
                        ProyectoActual.OfertaId = oferta[0];
                        ProyectoActual.Monto = float.Parse(txtMonto.Text);
                        ProyectoActual.PorcentajeAnticipo = int.Parse(numericUpDownPorcentaje.Value.ToString());
                        ProyectoActual.FacturaAnticipoId = txtNumeroFacturaAnticipo.Text;
                        ProyectoActual.FacturaFinalId = (string.IsNullOrEmpty(txtFacturalFinalId.Text)) ? "No ingresado" : txtFacturalFinalId.Text;
                        ProyectoActual.TareaId = int.Parse(txtTarea.Text);
                        ProyectoActual.Ubicacion = (string.IsNullOrEmpty(txtUbicacion.Text)) ? "No Ingresado" : txtUbicacion.Text;
                        ProyectoActual.FechaInicio = dtpInicio.Value;
                        ProyectoActual.FechaFinal = dtpFinalizacion.Value;
                        ProyectoActual.Estado = cbEstado.Text;
                        ProyectoActual.UltimoEditor = Temporal.UsuarioActivo.Nombre;
                        ProyectoActual.UltimaEdicion = DateTime.Now;

                        ProyectoActual.Vendedor = null;
                        //Envio a la DB

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
                string VendedorSeleccionado = cbVendedores.Text;
                string OfertaSeleccionada = comboBoxOfertas.Text;
                bool isvalid = int.TryParse(OfertaSeleccionada.Split('-').FirstOrDefault(), out int number);
                if (string.IsNullOrEmpty(OfertaSeleccionada) || !isvalid)
                {
                    MessageBox.Show($"Compruebe la oferta, el valor '{OfertaSeleccionada}' no es valido\nLa oferta debe tener este formado: [Numero Oferta]-[Nombre]\nSeleccione algún numero de oferta de los existentes o seleccione 1-No aplica/no disponible", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }
                if (string.IsNullOrEmpty(VendedorSeleccionado))
                {
                    MessageBox.Show("No ha seleccionado un vendedor", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }
                if (string.IsNullOrEmpty(txtRazonSocial.Text))
                {
                    MessageBox.Show("No ha digitado una razón social o nombre del cliente", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }
                if (string.IsNullOrEmpty(txtContacto.Text))
                {
                    MessageBox.Show("No ha digitado un contacto del ProyectoActual", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }
                float.TryParse(txtMonto.Text, out float Monto);
                if (Monto == 0)
                {
                    MessageBox.Show("Revise el campo monto", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }
                if (string.IsNullOrEmpty(txtFacturalFinalId.Text))
                {
                    MessageBox.Show("No hay datos ingresados de la factura final", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                int.TryParse(txtTarea.Text, out int numeroTarea);
                if (numeroTarea == 0)
                {
                    MessageBox.Show("Revise el numero de tarea digitado", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
    }
}
