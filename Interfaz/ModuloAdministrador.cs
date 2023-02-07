using Modelos;
using Negocio;
using Negocios;
using System.Data;
using System.Globalization;
using DataTable = System.Data.DataTable;
using Excel = Microsoft.Office.Interop.Excel;

namespace Interfaz
{
	public partial class ModuloAdministrador : Form
	{
		private List<Usuario> Vendedores = new();
		private List<Proyecto> proyectos = new();
		private List<Cliente> clientes = new();
		private Dictionary<int, string> Ofertas = new();
		public ModuloAdministrador()
		{
			InitializeComponent();
			Carga();
		}

		public async void Carga()
		{
			await CargarVendedoresAsync();
			await CargarTablaAsync();
			await cargarOfertas();
		}

		private void CargarClientes()
		{
			try
			{
			}
			catch (Exception ex)
			{
				MessageBox.Show($"Error interno {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
					cbOfertas.Items.Clear();
					foreach (var item in Ofertas)
					{
						cbOfertas.Items.Add($"{item.Key}-{item.Value}");
					}
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

		private void listarVendedoresToolStripMenuItem_Click(object sender, EventArgs e)
		{
			ListarUsuario listarUsuario = new();
			listarUsuario.ShowDialog();
			CargarVendedoresAsync();
		}

		private void agregarUsuarioToolStripMenuItem1_Click(object sender, EventArgs e)
		{
			AgregarUsuario agregarUsuario = new();
			agregarUsuario.ShowDialog();
			CargarVendedoresAsync();
		}

		private async Task CargarVendedoresAsync()
		{
			UsuarioNegocio usuarioNegocio = new();
			Vendedores = await usuarioNegocio.ListarVendedoresAsync();
			if (Vendedores.Count > 0)
			{
				cbVendedores.Items.Clear();
				foreach (var item in Vendedores)
				{
					cbVendedores.Items.Add(item.Nombre);
				}
			}
		}
		private async Task CargarTablaAsync(List<Proyecto> proyectosFiltrados = null)
		{
			if (proyectosFiltrados != null)
			{
				proyectos = proyectosFiltrados;
			}
			else
			{
				var proyectosNegocio = new ProyectoNegocios();
				proyectos = await proyectosNegocio.ListarProyectoAsync();
			}

			if (proyectos.Count > 0)
			{
				dgvProyectos.Columns.Clear();
				DataTable _tabla = new();
				_tabla.Columns.Add("Id Interno");
				_tabla.Columns.Add("Vendedor");
				_tabla.Columns.Add("Cliente");
				_tabla.Columns.Add("Fecha OC");
				_tabla.Columns.Add("Factura Anticipo");
				_tabla.Columns.Add("Oferta");
				_tabla.Columns.Add("Fecha Inicio");
				_tabla.Columns.Add("Fecha Final");
				_tabla.Columns.Add("Monto");
				_tabla.Columns.Add("Estado");
				foreach (Proyecto i in proyectos)
				{
					_tabla.Rows.Add(
						i.ProyectoId,
						i.Vendedor.Nombre,
						i.Cliente,
						i.FechaOC.ToLongDateString(),
						i.FacturaAnticipoId.ToString(),
						i.OfertaId,
						i.FechaInicio.ToLongDateString(),
						i.FechaFinal.ToLongDateString(),
						i.Monto.ToString("C", CultureInfo.CurrentCulture),
						i.Estado
						);
				}
				DataGridViewButtonColumn botonVer = new();
				botonVer.HeaderText = "Ver";
				botonVer.Text = "Ver";
				botonVer.Name = "btnVerProyecto";
				botonVer.UseColumnTextForButtonValue = true;
				dgvProyectos.Columns.Add(botonVer);
				DataGridViewButtonColumn botonEditar = new();
				botonEditar.HeaderText = "Editar";
				botonEditar.Text = "Editar";
				botonEditar.Name = "btnEditarProyecto";
				botonEditar.UseColumnTextForButtonValue = true;
				dgvProyectos.Columns.Add(botonEditar);

				dgvProyectos.DataSource = _tabla;



			}
		}

		private void dgvProyectos_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			if (e.ColumnIndex == 0)
			{
				VerProyecto verProyecto = new();
				var id = int.Parse(dgvProyectos.Rows[e.RowIndex].Cells[2].Value.ToString());
				verProyecto.idProyecto = id;
				verProyecto.ShowDialog();
			}
			else if (e.ColumnIndex == 1)
			{
				var id = int.Parse(dgvProyectos.Rows[e.RowIndex].Cells[2].Value.ToString());
				EditarProyecto editarProyecto = new();
				editarProyecto.ProyectoId = id;
				editarProyecto.ShowDialog();
				CargarTablaAsync();
			}
		}

		private void ModuloAdministrador_Load(object sender, EventArgs e)
		{

		}
		private void NumeroProyecto()
		{
			try
			{

			}
			catch (Exception f)
			{
				MessageBox.Show($"Error interno {f.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private async void listarOfertasToolStripMenuItem_Click(object sender, EventArgs e)
		{
			ListarOferta listarOferta = new();
			listarOferta.ShowDialog();
			await cargarOfertas();
		}

		private async void agregarOfertaToolStripMenuItem_Click(object sender, EventArgs e)
		{
			AgregarOferta agregarOferta = new();
			agregarOferta.ShowDialog();
			await cargarOfertas();
		}

		private void excelToolStripMenuItem_Click(object sender, EventArgs e)
		{
			try
			{
				saveFileDialog1.Title = "Exportar a Excel";
				saveFileDialog1.Filter = "Excel|*.xlsx";
				if (saveFileDialog1.ShowDialog() == DialogResult.OK)
				{
					string URLArchivo = saveFileDialog1.FileName;
					var ExcelApp = new Excel.Application();
					ExcelApp.Workbooks.Add();
					Excel._Worksheet worksheet = (Excel.Worksheet)ExcelApp.ActiveSheet;
					worksheet.Cells[1, "A"] = "Numero Proyecto";
					worksheet.Cells[1, "B"] = "Vendedor";
					worksheet.Cells[1, "C"] = "Cliente";
					worksheet.Cells[1, "D"] = "Factura Anticipo";
					worksheet.Cells[1, "E"] = "Factura Final";
					worksheet.Cells[1, "F"] = "Porcentaje Anticipo";
					worksheet.Cells[1, "G"] = "Tarea Bitrix";
					worksheet.Cells[1, "H"] = "Fecha OC";
					worksheet.Cells[1, "I"] = "Oferta";
					worksheet.Cells[1, "J"] = "Fecha Inicio";
					worksheet.Cells[1, "K"] = "Fecha Final";
					worksheet.Cells[1, "L"] = "Monto";
					int contador = 2;
					foreach (Proyecto item in proyectos)
					{
						worksheet.Cells[contador, 1] = item.ProyectoId.ToString();
						worksheet.Cells[contador, 2] = item.Vendedor.Nombre;
						worksheet.Cells[contador, 3] = item.Cliente;
						worksheet.Cells[contador, 4] = item.FacturaAnticipoId;
						worksheet.Cells[contador, 5] = item.FacturaFinalId;
						worksheet.Cells[contador, 6] = item.PorcentajeAnticipo;
						worksheet.Cells[contador, 7] = item.TareaId;
						worksheet.Cells[contador, 8] = item.FechaOC.ToLongDateString();
						worksheet.Cells[contador, 9] = item.OfertaId.ToString();
						worksheet.Cells[contador, 10] = item.FechaInicio.ToLongDateString();
						worksheet.Cells[contador, 11] = item.FechaFinal.ToLongDateString();
						worksheet.Cells[contador, 12] = item.Monto.ToString("C", CultureInfo.CurrentCulture);
						contador++;
					}
					ExcelApp.ActiveWorkbook.SaveAs(URLArchivo, Excel.XlFileFormat.xlWorkbookDefault);
					ExcelApp.ActiveWorkbook.Close();
					ExcelApp.Quit();
					MessageBox.Show("Documento Generado", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Ocurrió un problema. Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private async void btnAgregar_Click(object sender, EventArgs e)
		{
			try
			{
				ProyectoNegocios proyectoNegocios = new ProyectoNegocios();
				bool Resultado = ValidarCampos();
				if (Resultado)
				{
					Proyecto proyectoTemporal = new Proyecto();
					proyectoTemporal.Contacto = txtContacto.Text;
					proyectoTemporal.FechaOC = dtpOrdenCompra.Value;
					proyectoTemporal.FechaInicio = dtpFechaInicio.Value;
					proyectoTemporal.FechaFinal = dtpFechaFinal.Value;
					proyectoTemporal.Monto = int.Parse(txtMonto.Text);
					proyectoTemporal.Ubicacion = txtUbicacion.Text;
					proyectoTemporal.TareaId = int.Parse(txtNumeroTarea.Text);
					proyectoTemporal.Estado = cbEstado.Text;
					proyectoTemporal.FacturaAnticipoId = txtNumeroFactura.Text;
					proyectoTemporal.UsuarioId = (from i in Vendedores
												  where i.Nombre == cbVendedores.Text
												  select i.UsuarioId).FirstOrDefault();
					var ofertatmp = cbOfertas.Text.Split('-');
					proyectoTemporal.OfertaId = ofertatmp[0];
					proyectoTemporal.UltimoEditor = Temporal.UsuarioActivo.Nombre;
					proyectoTemporal.Autor = Temporal.UsuarioActivo.Nombre;
					proyectoTemporal.FacturaFinalId = string.Empty;
					proyectoTemporal.UltimaEdicion = DateTime.Today;
					proyectoTemporal.Cliente = txtNombreCliente.Text;
					proyectoTemporal.Enable = true;
					var resultado = proyectoNegocios.CrearProyecto(proyectoTemporal, out int idProyecto);
					if (resultado)
					{
						MessageBox.Show($"Proyecto agregado. Id: {idProyecto}", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
						await CargarTablaAsync();
						Limpiar();
					}
					else
					{
						MessageBox.Show($"Error Interno", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
					}

				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Ocurrió un problema. Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private bool ValidarCampos()
		{
			try
			{
				var vendedorSeleccionado = cbVendedores.Text;
				var ofertaSeleccionada = cbOfertas.Text;
				var clienteSeleccionado = txtNombreCliente.Text;
				if (string.IsNullOrEmpty(vendedorSeleccionado) || string.IsNullOrEmpty(ofertaSeleccionada) || string.IsNullOrEmpty(clienteSeleccionado))
				{
					MessageBox.Show("Verifique los desplegables ", "", MessageBoxButtons.OK);
					return false;
				}
				int.TryParse(txtMonto.Text, out int resultado);
				if (resultado == 0)
				{
					MessageBox.Show("Indique el monto del proyecto");
					return false;
				}
				int.TryParse(txtNumeroTarea.Text, out int resultado1);
				if (resultado1 == 0)
				{
					MessageBox.Show("Indique el numero de tarea en bitrix");
					return false;
				}
				if (string.IsNullOrEmpty(txtContacto.Text))
				{
					MessageBox.Show("Indique el nombre del contacto");
					return false;
				}
				if (numericUpDownPorcentaje.Value == 0)
				{
					MessageBox.Show("Indique un porcentaje mayor a 0");
					return false;
				}
				return true;
			}
			catch (Exception f)
			{
				Console.WriteLine(f.Message);
				return false;
			}
		}

		private void archivoToolStripMenuItem_Click(object sender, EventArgs e)
		{

		}

		private void salirToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void ayudaToolStripMenuItem_Click(object sender, EventArgs e)
		{
			MessageBox.Show("Contacte al departamento de TI", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
		}

		private void button2_Click(object sender, EventArgs e)
		{

		}
		private void Limpiar()
		{
			cbVendedores.Text = string
				.Empty;
			txtNombreCliente.Text = string.Empty;
			dtpOrdenCompra.Value = DateTime.Now;
			txtContacto.Text = string.Empty;
			cbOfertas.Text = string.Empty;
			txtMonto.Text = string.Empty;
			numericUpDownPorcentaje.Value = 0;
			txtNumeroFactura.Text = string.Empty;
			txtNumeroTarea.Text = string.Empty;
			txtUbicacion.Text = string.Empty;
			dtpFechaInicio.Value = DateTime.Now;
			dtpFechaFinal.Value = DateTime.Now;
			cbEstado.Text = string.Empty;
		}

		private async void btnBuscar_Click(object sender, EventArgs e)
		{
			if (!string.IsNullOrEmpty(txtNombreBuscar.Text) && !string.IsNullOrEmpty(txtNumeroProyectoBuscar.Text))
			{
				int.TryParse(txtNumeroProyectoBuscar.Text, out int idProyecto);
				var proyectosFiltrados = (from p in proyectos
										  where p.Cliente.ToUpper().Contains(txtNombreBuscar.Text.ToUpper()) && p.ProyectoId == idProyecto
										  select p).ToList();
				if (proyectosFiltrados.Count > 0)
				{
					await CargarTablaAsync(proyectosFiltrados);
				}
				else
				{
					MessageBox.Show("No hay coindencias", "Adventencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				}
			}
			else if (!string.IsNullOrEmpty(txtNombreBuscar.Text))
			{
				var proyectosFiltrados = (from p in proyectos
										  where p.Cliente.ToUpper().Contains(txtNombreBuscar.Text.ToUpper())
										  select p).ToList();
				if (proyectosFiltrados.Count > 0)
				{
					CargarTablaAsync(proyectosFiltrados);
				}
				else
				{
					MessageBox.Show("No hay coindencias", "Adventencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				}
			}
			else if (!string.IsNullOrEmpty(txtNumeroProyectoBuscar.Text))
			{
				int.TryParse(txtNumeroProyectoBuscar.Text, out int idProyecto);
				var proyectosFiltrados = (from p in proyectos
										  where p.ProyectoId == idProyecto
										  select p).ToList();
				if (proyectosFiltrados.Count > 0)
				{
					CargarTablaAsync(proyectosFiltrados);
				}
				else
				{
					MessageBox.Show("No hay coindencias", "Adventencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				}
			}
		}

		private void btnLimpiarBusqueda_Click(object sender, EventArgs e)
		{
			txtNombreBuscar.Text = string.Empty;
			txtNumeroProyectoBuscar.Text = string.Empty;
			CargarTablaAsync();
		}

		private void txtMonto_Leave(object sender, EventArgs e)
		{
			bool parseable = float.TryParse(txtMonto.Text, out float resultado);
			if (!parseable) {
				MessageBox.Show($"El valor {txtMonto.Text} no es valido, reviselo\n Ejemplo: 1520,25","",MessageBoxButtons.OK);
			}

		}
	}
}
