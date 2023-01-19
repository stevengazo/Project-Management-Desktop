using Modelos;
using Negocios;
using System.Data;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;

namespace Interfaz
{
	public partial class ModuloVentas : Form
	{
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
			CargarVendedores();
		}


		private void CargarVendedores()
		{
			UsuarioNegocio usuarioNegocio = new();
			Vendedores = usuarioNegocio.ListarVendedores();
			if(Vendedores.Count > 0)
			{
				foreach (var item in Vendedores)
				{
					cbVendedores.Items.Add(item.Nombre);
				}
			}
		}
		private void CargarTabla()
		{
			var proyectosNegocio = new ProyectoNegocios();
			proyectos = proyectosNegocio.ListaProyectos(Temporal.UsuarioActivo.UsuarioId);
			if (proyectos.Count > 0)
			{
				DataTable _tabla = new();

				_tabla.Columns.Add("Numero Proyecto");
				_tabla.Columns.Add("Vendedor");
				_tabla.Columns.Add("Raz[on Social");
				_tabla.Columns.Add("Fecha OC");
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
						i.FechaOC,
						i.OfertaId,
						i.FechaInicio.ToLongDateString(),
						i.FechaFinal.ToLongDateString(),
						i.Monto,
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
							worksheet.Cells[contador, 3] = item.FechaOC.ToLongDateString();
							worksheet.Cells[contador, 4] = item.OfertaId.ToString();
							worksheet.Cells[contador, 5] = item.FechaInicio.ToLongDateString();
							worksheet.Cells[contador, 6] = item.FechaFinal.ToLongDateString();
							worksheet.Cells[contador, 7] = item.Monto.ToString();
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

			}
			catch (Exception r)
			{
				MessageBox.Show(r.Message);
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
			if(e.ColumnIndex == 9)
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
	}
}