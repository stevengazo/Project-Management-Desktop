using Modelos;
using Negocio;
using Negocios;
using System.Data;
using System.Globalization;
using Excel = Microsoft.Office.Interop.Excel;

namespace Interfaz
{
	public partial class ModuloVentas : Form
	{
		private Dictionary<int, string> Ofertas = new();
		private List<Proyecto> proyectos = new();
		private Proyecto ProyectoTemporal = new();
		private List<Usuario> Vendedores = new();
		public ModuloVentas()
		{
			InitializeComponent();
		}

		private void agregarRazónSocialToolStripMenuItem_Click(object sender, EventArgs e)
		{



		}

		private void agregarToolStripMenuItem_Click(object sender, EventArgs e)
		{

		}

		private void Form1_Load(object sender, EventArgs e)
		{
			CargarTabla();
			cargarOfertas();
			CargarVendedores();
			this.Text = $"Modulo Ventas - Asfaltos - Bienvenido {Temporal.UsuarioActivo.Nombre}";
		}

		private void cargarOfertas()
		{
			try
			{
				OfertaNegocio ofertaNegocio = new();
				Ofertas = ofertaNegocio.DiccionarioOfertas();
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


		private void CargarVendedores()
		{
			UsuarioNegocio usuarioNegocio = new();
			Vendedores = usuarioNegocio.ListarVendedores();
			if (Vendedores.Count > 0)
			{
				foreach (var item in Vendedores)
				{
					cbVendedores.Items.Add(item.Nombre);
				}
			}
		}
		private async Task CargarTabla(List<Proyecto> proyectosListados = null)
		{
			var proyectosNegocio = new ProyectoNegocios();
			if (proyectosListados != null)
			{
				proyectos = proyectosListados;
			}
			else
			{
				proyectos = await proyectosNegocio.ListaProyectos(Temporal.UsuarioActivo.UsuarioId);
			}
			if (proyectos.Count > 0)
			{
				DataTable _tabla = new();

				_tabla.Columns.Add("Numero Proyecto");
				_tabla.Columns.Add("Vendedor");
				_tabla.Columns.Add("Razon Social");
				_tabla.Columns.Add("Fecha OC");
				_tabla.Columns.Add("Oferta");
				_tabla.Columns.Add("Porcentaje");
				_tabla.Columns.Add("Id Factura Anticipo");
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
						i.OfertaId,
						$"{i.PorcentajeAnticipo}%",
						i.FacturaAnticipoId,
						i.FechaInicio.ToLongDateString(),
						i.FechaFinal.ToLongDateString(),
						i.Monto.ToString("C", CultureInfo.CurrentCulture),
						i.Estado
						);
				}
				dgvProyectos.DataSource = _tabla;
				DataGridViewButtonColumn botonVer = new();
				botonVer.HeaderText = "Ver";
				botonVer.Text = "Ver";
				botonVer.Name = "btnVerProyecto";
				botonVer.UseColumnTextForButtonValue = true;
				dgvProyectos.Columns.Add(botonVer);
			}
		}


		private void LimpiarDatos()
		{
			cbVendedores.Text = string.Empty;
			txtRazonSocial.Text = string.Empty;
			dtpFechaOC.Value = DateTime.Now;
			txtContacto.Text = string.Empty;
			comboBoxOfertas.Text = string.Empty;
			txtMonto.Text = string.Empty;
			numericUpDownPorcentaje.Value = 0;
			txtNumeroFacturaAnticipo.Text = string.Empty;
			txtTareaBitrix.Text = string.Empty;
			textBoxUbicacion.Text = string.Empty;
			dateTimePickerInicio.Value = DateTime.Now;
			dateTimePickerFinal.Value = DateTime.Now;
			comboBoxEstado.Text = string.Empty;
		}

		private void usuariosToolStripMenuItem_Click(object sender, EventArgs e)
		{
			ListarUsuario listarUsuariotmp = new();
			listarUsuariotmp.ShowDialog();
		}

		private void excelToolStripMenuItem_Click(object sender, EventArgs e)
		{
			try
			{
				if (proyectos.Count > 0)
				{
					saveFileDialog.Title = "Exportar Proyectos";
					saveFileDialog.Filter = "Hoja de Calculo|*.xlsx";
					if (saveFileDialog.ShowDialog() == DialogResult.OK)
					{

						string URLArchivo = saveFileDialog.FileName;
						var ExcelApp = new Excel.Application();
						ExcelApp.Workbooks.Add();
						Excel._Worksheet worksheet = (Excel.Worksheet)ExcelApp.ActiveSheet;
						worksheet.Cells[1, "A"] = "Numero Proyecto";
						worksheet.Cells[1, "B"] = "Vendedor";
						worksheet.Cells[1, "B"] = "Cliente";
						worksheet.Cells[1, "C"] = "Fecha OC";
						worksheet.Cells[1, "D"] = "Oferta";
						worksheet.Cells[1, "E"] = "Fecha Inicio";
						worksheet.Cells[1, "F"] = "Fecha Final";
						worksheet.Cells[1, "G"] = "Monto";
						int contador = 2;
						foreach (Proyecto item in proyectos)
						{
							worksheet.Cells[contador, 1] = item.ProyectoId.ToString();
							worksheet.Cells[contador, 2] = item.Vendedor.Nombre;
							worksheet.Cells[contador, 3] = item.Cliente;
							worksheet.Cells[contador, 4] = item.FechaOC.ToLongDateString();
							worksheet.Cells[contador, 5] = item.OfertaId.ToString();
							worksheet.Cells[contador, 6] = item.FechaInicio.ToLongDateString();
							worksheet.Cells[contador, 7] = item.FechaFinal.ToLongDateString();
							worksheet.Cells[contador, 8] = item.Monto.ToString();
							contador++;
						}
						ExcelApp.ActiveWorkbook.SaveAs(URLArchivo, Excel.XlFileFormat.xlWorkbookDefault);
						ExcelApp.ActiveWorkbook.Close();
						ExcelApp.Quit();

					}
				}
				else
				{
					MessageBox.Show("No hay proyectos para exportar", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}

		}
		private void btnAgregar_Click(object sender, EventArgs e)
		{
			try
			{
				bool estado = ValidarCampos();
				if (estado)
				{
					Proyecto proyectoNuevo = new Proyecto();

					// Seguridad y edicion
					proyectoNuevo.Autor = Temporal.UsuarioActivo.Nombre;
					proyectoNuevo.UltimaEdicion = DateTime.Now;
					proyectoNuevo.UltimoEditor = Temporal.UsuarioActivo.Nombre;

					// No viisble
					proyectoNuevo.FacturaFinalId = string.Empty;
					proyectoNuevo.Enable = true;

					var vendedor = (from v in Vendedores
									where v.Nombre == cbVendedores.Text
									select v.UsuarioId).FirstOrDefault();
					proyectoNuevo.UsuarioId = vendedor;
					proyectoNuevo.Cliente = txtRazonSocial.Text;
					proyectoNuevo.FechaOC = dtpFechaOC.Value;
					proyectoNuevo.Contacto = txtContacto.Text;
					var oferta = comboBoxOfertas.Text.Split('-');
					proyectoNuevo.OfertaId = oferta[0];
					proyectoNuevo.Monto = float.Parse(txtMonto.Text);
					proyectoNuevo.PorcentajeAnticipo = (int)numericUpDownPorcentaje.Value;
					proyectoNuevo.FacturaAnticipoId = txtNumeroFacturaAnticipo.Text;
					proyectoNuevo.TareaId = int.Parse(txtTareaBitrix.Text);
					if (string.IsNullOrEmpty(textBoxUbicacion.Text))
					{
						proyectoNuevo.Ubicacion = string.Empty;
					}
					else
					{
						proyectoNuevo.Ubicacion = textBoxUbicacion.Text;
					}
					proyectoNuevo.FechaInicio = dateTimePickerInicio.Value;
					proyectoNuevo.FechaFinal = dateTimePickerFinal.Value;
					proyectoNuevo.Estado = comboBoxEstado.Text;

					ProyectoNegocios proyectoNegocios = new();
					var resultado = proyectoNegocios.CrearProyecto(proyectoNuevo, out int idProyecto);
					if (resultado)
					{
						MessageBox.Show($"Proyecto agregado. Id: {idProyecto}", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
						CargarTabla();
						LimpiarDatos();
					}
					else
					{
						MessageBox.Show($"Error Interno", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
					}
				}
			}
			catch (Exception r)
			{
				MessageBox.Show(r.Message);
			}
		}

		private bool ValidarCampos()
		{
			try
			{
				var VendedorSeleccionado = cbVendedores.Text;
				if (string.IsNullOrEmpty(VendedorSeleccionado))
				{
					MessageBox.Show(" ", "", MessageBoxButtons.OK);
					return false;
				}
				if (string.IsNullOrEmpty(txtRazonSocial.Text))
				{
					MessageBox.Show("", "", MessageBoxButtons.OK);
					return false;
				}
				if (string.IsNullOrEmpty(txtContacto.Text))
				{
					MessageBox.Show("", "", MessageBoxButtons.OK);
					return false;
				}
				var Oferta = comboBoxOfertas.Text;
				if (string.IsNullOrEmpty(Oferta))
				{
					MessageBox.Show("", "", MessageBoxButtons.OK);
					return false;
				}
				float.TryParse(txtMonto.Text, out float monto);
				if (monto == 0)
				{
					MessageBox.Show("", "", MessageBoxButtons.OK);
					return false;
				}
				int.TryParse(txtNumeroFacturaAnticipo.Text, out int facturaanticipo);
				if (facturaanticipo == 0)
				{
					MessageBox.Show("", "", MessageBoxButtons.OK);
					return false;
				}
				int.TryParse(txtTareaBitrix.Text, out int tarea);
				if (tarea == 0)
				{
					MessageBox.Show("", "", MessageBoxButtons.OK);
					return false;
				}
				if (string.IsNullOrEmpty(comboBoxEstado.Text))
				{
					MessageBox.Show("", "", MessageBoxButtons.OK);
					return false;
				}
				return true;
			}
			catch (Exception f)
			{
				return false;
			}
		}

		private void salirToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void usuariosToolStripMenuItem_Click_1(object sender, EventArgs e)
		{
			ListarUsuario listarUsuariousuarios = new();
			listarUsuariousuarios.ShowDialog();
		}

		private void agregarUsuariosToolStripMenuItem_Click(object sender, EventArgs e)
		{
			AgregarUsuario agregarUsuario = new();
			agregarUsuario.ShowDialog();
		}

		private void verCotizacionesToolStripMenuItem_Click(object sender, EventArgs e)
		{
			ListarOferta listarOferta = new();
			listarOferta.ShowDialog();

		}

		private void dgvProyectos_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			if (e.ColumnIndex == 9)
			{
				VerProyecto verProyecto = new();
				var id = int.Parse(dgvProyectos.Rows[e.RowIndex].Cells[0].Value.ToString());
				verProyecto.idProyecto = id;
				verProyecto.ShowDialog();
			}
		}

		private void agregarCotizaciónToolStripMenuItem_Click(object sender, EventArgs e)
		{
			AgregarOferta agregarOferta = new();
			agregarOferta.ShowDialog();
		}

		private void btnLimpiar_Click(object sender, EventArgs e)
		{

		}

		private void btnLimpiar_Click_1(object sender, EventArgs e)
		{
			LimpiarDatos();
		}

		private void btnBuscar_Click(object sender, EventArgs e)
		{
			try
			{
				if (!string.IsNullOrEmpty(txtClienteBuscar.Text) && !string.IsNullOrEmpty(txtNumeroPBuscar.Text))
				{
					int.TryParse(txtNumeroPBuscar.Text, out int idProyecto);
					var proyectosFiltrados = (from p in proyectos
											  where p.Cliente.ToUpper().Contains(txtClienteBuscar.Text.ToUpper()) && p.ProyectoId == idProyecto
											  select p).ToList();
					if (proyectosFiltrados.Count > 0)
					{
						CargarTabla(proyectosFiltrados);
					}
					else
					{
						MessageBox.Show("No hay coindencias", "Adventencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
					}
				}
				else if (!string.IsNullOrEmpty(txtClienteBuscar.Text))
				{
					var proyectosFiltrados = (from p in proyectos
											  where p.Cliente.ToUpper().Contains(txtClienteBuscar.Text.ToUpper())
											  select p).ToList();
					if (proyectosFiltrados.Count > 0)
					{
						CargarTabla(proyectosFiltrados);
					}
					else
					{
						MessageBox.Show("No hay coindencias", "Adventencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
					}
				}
				else if (!string.IsNullOrEmpty(txtNumeroPBuscar.Text))
				{
					int.TryParse(txtNumeroPBuscar.Text, out int idProyecto);
					var proyectosFiltrados = (from p in proyectos
											  where p.ProyectoId == idProyecto
											  select p).ToList();
					if (proyectosFiltrados.Count > 0)
					{
						CargarTabla(proyectosFiltrados);
					}
					else
					{
						MessageBox.Show("No hay coindencias", "Adventencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
					}
				}
				txtNumeroPBuscar.Text = string.Empty;
				txtClienteBuscar.Text = string.Empty;
			}
			catch (Exception f)
			{

			}
		}

		private void limpar_Click(object sender, EventArgs e)
		{
			txtNumeroPBuscar.Text = string.Empty;
			txtClienteBuscar.Text = string.Empty;
			CargarTabla();
		}
	}
}