using Modelos;
using Negocio;
using Negocios;
using System.Data;

namespace Interfaz
{
	public partial class EditarProyecto : Form
	{
		private List<Usuario> Vendedores = new();
		private Dictionary<int, string> Ofertas = new();
		private Proyecto ProyectoActual { get; set; }

		public int ProyectoId { get; set; } = 0;
		public EditarProyecto()
		{
			InitializeComponent();
		}

		private async Task CargarVendedores()
		{
			UsuarioNegocio usuarioNegocio = new();
			Vendedores = usuarioNegocio.ListarVendedores();
			if (Vendedores.Count > 0)
			{
				cbVendedores.Items.Clear();
				foreach (var item in Vendedores)
				{
					cbVendedores.Items.Add(item.Nombre);
				}
			}
		}

		private async Task cargarOfertas()
		{
			try
			{
				OfertaNegocio ofertaNegocio = new();
				Ofertas = await ofertaNegocio.DiccionarioOfertasAsync();
				if (Ofertas != null)
				{
					comboBoxOfertas.Items.Clear();
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
		private void btnBorrar_Click(object sender, EventArgs e)
		{
			var Resultado = MessageBox.Show("¿Deseas borrar este ProyectoActual?", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
			if (Resultado == DialogResult.Yes)
			{
				ProyectoNegocios proyectoNegocios = new ProyectoNegocios();
				var resultado1 = proyectoNegocios.DesactivarProyecto(ProyectoActual.ProyectoId);
				if (resultado1)
				{
					MessageBox.Show("Proyecto Desactivado \nEste proyecto no se encontrará visible para los usuarios \nPara volver a activarlo contacte con el administrador de la DB", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
					this.Close();
				}
			}
		}

		private async void EditarProyecto_Load(object sender, EventArgs e)
		{
			await cargarOfertas();
			await CargarVendedores();
			if (ProyectoId != 0)
			{
				ProyectoNegocios proyectoNegocios = new();
				ProyectoActual = proyectoNegocios.ObtenerProyecto(ProyectoId);
				txtNumeroProyecto.Text = ProyectoActual.ProyectoId.ToString();
				// vendedor
				cbVendedores.Text = ProyectoActual.Vendedor.Nombre;
				txtRazonSocial.Text = ProyectoActual.Cliente;
				dtpOC.Value = ProyectoActual.FechaOC;
				txtContacto.Text = ProyectoActual.Cliente;
				// oferta
				var ofertaIdTemporal = int.Parse(ProyectoActual.OfertaId);
				var oferta = (from O in Ofertas
							  where O.Key == ofertaIdTemporal
							  select O).FirstOrDefault();
				comboBoxOfertas.Text = $"{oferta.Key}-{oferta.Value}";

				txtMonto.Text = ProyectoActual.Monto.ToString();
				numericUpDownPorcentaje.Value = ProyectoActual.PorcentajeAnticipo;
				txtNumeroFacturaAnticipo.Text = ProyectoActual.FacturaAnticipoId;
				txtTarea.Text = ProyectoActual.TareaId.ToString();
				txtUbicacion.Text = ProyectoActual.Ubicacion;
				dtpInicio.Value = ProyectoActual.FechaInicio;
				dtpFinalizacion.Value = ProyectoActual.FechaFinal;
				cbEstado.Text = ProyectoActual.Estado;
			}
			else
			{
				MessageBox.Show("Error interno", "Advertencia");
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
						if (string.IsNullOrEmpty(txtFacturalFinalId.Text))
						{
							ProyectoActual.FacturaFinalId = string.Empty;
						}
						else
						{
							ProyectoActual.FacturaFinalId = txtFacturalFinalId.Text;
						}
						ProyectoActual.TareaId = int.Parse(txtTarea.Text);
						if (string.IsNullOrEmpty(txtUbicacion.Text))
						{
							ProyectoActual.Ubicacion = string.Empty;
						}
						else
						{
							ProyectoActual.Ubicacion = txtUbicacion.Text;
						}
						ProyectoActual.FechaInicio = dtpInicio.Value;
						ProyectoActual.FechaFinal = dtpFinalizacion.Value;
						ProyectoActual.Estado = cbEstado.Text;

						ProyectoActual.UltimoEditor = Temporal.UsuarioActivo.Nombre;
						ProyectoActual.UltimaEdicion = DateTime.Now;

						//Envio a la DB

						bool resultado = proyectoNegocios.ActualizarProyecto(ProyectoActual);
						if (resultado)
						{
							MessageBox.Show("Proyecto Actualizado", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
		private bool ValidarDatos()
		{
			try
			{
				string VendedorSeleccionado = cbVendedores.Text;
				string OfertaSeleccionada = comboBoxOfertas.Text;
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
	}
}
