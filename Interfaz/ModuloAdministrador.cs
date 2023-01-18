using Modelos;
using Negocios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;
using System.Reflection;
using DataTable = System.Data.DataTable;
using Negocio;

namespace Interfaz
{
	public partial class ModuloAdministrador : Form
	{
		private List<Usuario> Vendedores = new();
		private List<Proyecto> proyectos = new();
		private List<Cliente> clientes = new();
		private Dictionary<int,string> Ofertas = new();
		public ModuloAdministrador()
		{
			InitializeComponent();
			CargarVendedores();
			CargarTabla();
			cargarOfertas();
			CargarClientes();
		}

		private void CargarClientes()
		{
			try
			{
				ClienteNegocio clienteNegocio = new();
				clientes = clienteNegocio.ListaClientes();
				if (clientes.Count > 0)
				{
					foreach (Cliente i in clientes)
					{
						cbClientes.Items.Add(i.ClienteName);
					}
				}

			}
			catch (Exception ex)
			{
				MessageBox.Show($"Error interno {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void cargarOfertas()
		{
			try
			{
				OfertaNegocio ofertaNegocio = new();
				List<Oferta> ofertas = new();
				ofertas = ofertaNegocio.ListaOfertasPorAño();
				if (ofertas != null)
				{
					foreach (var item in ofertas)
					{
						cbOfertas.Items.Add(item.OfertaId);
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
		}

		private void agregarUsuarioToolStripMenuItem1_Click(object sender, EventArgs e)
		{
			AgregarUsuario agregarUsuario = new();
			agregarUsuario.ShowDialog();
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
		private void CargarTabla()
		{
			var proyectosNegocio = new ProyectoNegocios();
			proyectos = proyectosNegocio.ListaProyectos();
			if (proyectos.Count > 0)
			{
				DataTable _tabla = new();
				_tabla.Columns.Add("Numero Proyecto");
				_tabla.Columns.Add("Vendedor");
				_tabla.Columns.Add("Cliente");
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
						i.Cliente.ClienteName,
						i.FechaOC.ToShortTimeString(),
						i.OfertaId,
						i.FechaInicio.ToShortTimeString(),
						i.FechaFinal.ToShortTimeString(),
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
				DataGridViewButtonColumn botonEditar = new();
				botonEditar.HeaderText = "Editar";
				botonEditar.Text = "Editar";
				botonEditar.Name = "btnEditarProyecto";
				botonEditar.UseColumnTextForButtonValue = true;
				dgvProyectos.Columns.Add(botonEditar);
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
				EditarProyecto editarProyecto = new();
				editarProyecto.ShowDialog();
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
				MessageBox.Show("Error interno", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void listarOfertasToolStripMenuItem_Click(object sender, EventArgs e)
		{
			ListarOferta listarOferta = new();
			listarOferta.ShowDialog();
		}

		private void agregarOfertaToolStripMenuItem_Click(object sender, EventArgs e)
		{
			AgregarOferta agregarOferta = new();
			agregarOferta.ShowDialog();
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
			catch (Exception ex)
			{
				MessageBox.Show("Ocurrió un problema. Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);


			}
		}

		private void btnAgregar_Click(object sender, EventArgs e)
		{
			bool Resultado = ValidarCampos();
			if (Resultado)
			{
				Proyecto proyectoTemporal = new Proyecto();
				proyectoTemporal.Contacto = txtContacto.Text;
				proyectoTemporal.FechaOC = dtpOrdenCompra.Value;
				proyectoTemporal.FechaInicio = dtpFechaInicio.Value;
				proyectoTemporal.FechaFinal = dtpFechaFinal.Value;
				proyectoTemporal.Monto = int.Parse(txtMonto.Text);
				proyectoTemporal.Ubicacion= txtUbicacion.Text;
				proyectoTemporal.TareaId = int.Parse(txtNumeroTarea.Text);
				proyectoTemporal.Estado = cbEstado.Text;

				proyectoTemporal.Vendedor = (from i in Vendedores
											 where i.Nombre == cbVendedores.Text
											 select i).FirstOrDefault();
				proyectoTemporal.OfertaId = (from i in ofertas)
			}
		}

		private bool ValidarCampos()
		{
			try
			{
				var vendedorSeleccionado = cbVendedores.Text;
				var ofertaSeleccionada = cbOfertas.Text;
				var clienteSeleccionado = cbClientes.Text;
				if (string.IsNullOrEmpty(vendedorSeleccionado) || string.IsNullOrEmpty(ofertaSeleccionada) || string.IsNullOrEmpty(clienteSeleccionado))
				{
					MessageBox.Show("Verifique los desplegables ");
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
				if (numericUpDownPorcentaje.Value== 0)
				{
					MessageBox.Show("Indique un porcentaje mayor a 0");
					return false;
				}
				return true;
			}
			catch (Exception f)
			{
				return false;
			}
		}
	}
}
