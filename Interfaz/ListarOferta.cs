using Modelos;
using Negocio;
using System.Data;
using System.Globalization;

namespace Interfaz
{
	public partial class ListarOferta : Form
	{
		public ListarOferta()
		{
			InitializeComponent();
		}

		private void ListarOferta_Load(object sender, EventArgs e)
		{
			if (Temporal.TipoLogin.Equals("Administrador"))
			{
				CargarTablaAdministradores();
			}
			else
			{
				CargarTablaVendedores();
			}

		}

		private async Task CargarTablaVendedores()
		{
			try
			{
				int IdUsuario = Temporal.UsuarioActivo.UsuarioId;
				OfertaNegocio ofertaNegocio = new();
				var ofertas = await ofertaNegocio.ListaOfertasPorAñoAsync(DateTime.Now.Year);
				if (ofertas.Count > 0)
				{
					DataTable _tabla = new();
					_tabla.Columns.Add("Oferta Id");
					_tabla.Columns.Add("Fecha");
					//_tabla.Columns.Add("Codigo");
					_tabla.Columns.Add("Sellador");
					_tabla.Columns.Add("Asfalto");
					_tabla.Columns.Add("SubBase");
					_tabla.Columns.Add("Excavacion");
					_tabla.Columns.Add("Monto");
					_tabla.Columns.Add("Cliente");
					_tabla.Columns.Add("Encargado");
					_tabla.Columns.Add("Cotizado Por");


					foreach (Oferta item in ofertas)
					{
						_tabla.Rows.Add(
							$"CM-{item.OfertaId.ToString()}",
							item.Fecha.ToLongDateString(),
							//item.Codigo,
							item.Sellador,
							item.Asfalto,
							item.SubBase,
							item.Excavacion,
							item.Monto.ToString("C", CultureInfo.CurrentCulture),
							item.Cliente,
							item.Encargado.Nombre,
							item.EncargadoCotizador
							);
					}
					dgvOfertas.DataSource = _tabla;
				}
			}
			catch (Exception f)
			{
				MessageBox.Show("Error interno", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}


		}
		private async Task CargarTablaAdministradores()
		{
			OfertaNegocio ofertaNegocio = new();
			var listaOfertas = await ofertaNegocio.ListaOfertasAsync();
			if (listaOfertas.Count > 0)
			{
				DataTable _tabla = new();
				_tabla.Columns.Add("Oferta Id");
				_tabla.Columns.Add("Fecha");
				//_tabla.Columns.Add("Codigo");
				_tabla.Columns.Add("Sellador");
				_tabla.Columns.Add("Asfalto");
				_tabla.Columns.Add("SubBase");
				_tabla.Columns.Add("Excavacion");
				_tabla.Columns.Add("Monto");
				_tabla.Columns.Add("Encargado");
				_tabla.Columns.Add("Creado por");
				_tabla.Columns.Add("Cotizado Por");

				foreach (Oferta item in listaOfertas)
				{
					_tabla.Rows.Add(
						$"CM-{item.OfertaId.ToString()}",
						item.Fecha.ToLongDateString(),
						//item.Codigo,
						item.Sellador,
						item.Asfalto,
						item.SubBase,
						item.Excavacion,
						item.Monto.ToString("C", CultureInfo.CurrentCulture),
						item.Encargado.Nombre,
						item.AutorPrespuesto,
						item.EncargadoCotizador
						);
				}
				dgvOfertas.DataSource = _tabla;
			}
			else
			{

			}
		}

		private void salirToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void agregarOfertaToolStripMenuItem_Click(object sender, EventArgs e)
		{
			AgregarOferta agregarOferta = new();
			agregarOferta.ShowDialog();
			if (Temporal.TipoLogin.Equals("Administrador"))
			{
				CargarTablaAdministradores();
			}
			else
			{
				CargarTablaVendedores();
			}

		}

		private void btnAgregar_Click(object sender, EventArgs e)
		{

		}

		private void BtnLimpar_Click(object sender, EventArgs e)
		{
			txtCliente.Text = string.Empty;
			txtNumeroProyecto.Text = string.Empty;
			txtVendedor.Text = string.Empty;
			if (Temporal.TipoLogin.Equals("Administrador"))
			{
				CargarTablaAdministradores();
			}
			else
			{
				CargarTablaVendedores();
			}
		}
	}
}
