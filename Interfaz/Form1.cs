using Modelos;
using Negocios;
using System.Data;
using System.Windows.Forms;

namespace Interfaz
{
	public partial class Form1 : Form
	{
		private List<Proyecto> proyectos = new();
		public Form1()
		{
			InitializeComponent();
		}

		private void agregarRazónSocialToolStripMenuItem_Click(object sender, EventArgs e)
		{
			AgregarCliente tmp1= new AgregarCliente();
			tmp1.ShowDialog();
			// Actualizar combobox
			CargarClientes();
			
		}

		private void agregarToolStripMenuItem_Click(object sender, EventArgs e)
		{
			AgregarVendedor tmp1 = new AgregarVendedor();
			tmp1.ShowDialog();
			CargarVendedores();
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			CargarVendedores();
			CargarTabla();
			CargarClientes();
		}

		private void CargarVendedores()
		{
			try
			{
				var VendedoresNegocios = new VendedorNegocio();
				var listaVendedores = VendedoresNegocios.ListarVendedores();
				cbVendedores.Items.Clear();
				foreach (Vendedor i in listaVendedores) { 
					cbVendedores.Items.Add(i.Nombre);
				}

			}catch (Exception ex) {
				MessageBox.Show(ex.Message);
			}

		}
		private void CargarClientes()
		{
			try
			{
				var ClienteNegocios = new ClienteNegocio();
				var listaClientes = ClienteNegocios.ListarClientes();
				cbCliente.Items.Clear();
				foreach (Cliente i in listaClientes)
				{
					cbCliente.Items.Add($"{i.RazonSocial} - {i.Cedula} ");
				}

			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}
		private void CargarTabla()
		{
			var proyectosNegocio = new ProyectoNegocios();
			proyectos = proyectosNegocio.ListaProyectos();
			if(proyectos.Count > 0)
			{
				DataTable _tabla = new();

				_tabla.Columns.Add("Numero Proyecto");
				_tabla.Columns.Add("Vendedor");
				_tabla.Columns.Add("Raz[on Social");
				_tabla.Columns.Add("Fecha OC");
				_tabla.Columns.Add("Oferta");
				_tabla.Columns.Add("Fecha Inicio");
				_tabla.Columns.Add("Fecha Final");
				_tabla.Columns.Add("Estado");


				foreach ( Proyecto i in proyectos)
				{
					_tabla.Rows.Add(
						i.ProyectoId,
						i.Vendedor.Nombre,
						i.Cliente.RazonSocial,
						i.FechaOC,
						i.OfertaId,
						i.FechaInicio.ToLongDateString(),
						i.FechaFinal.ToLongDateString(),
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

		private void razonesSocialesToolStripMenuItem_Click(object sender, EventArgs e)
		{
			ListarCliente tmp = new();
			tmp.ShowDialog();
		}

		private void listaToolStripMenuItem_Click(object sender, EventArgs e)
		{
			ListarVendedor tmp = new();
			tmp.ShowDialog();
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
				if(proyectos.Count>0) {
					saveFileDialog.Title = "Exportar Proyectos";
					saveFileDialog.Filter = "Hoja de Calculo|*.xlsx";
					if(saveFileDialog.ShowDialog() == DialogResult.OK)
					{

					}
				}
				else
				{
					MessageBox.Show("No hay proyectos para exportar","Info",MessageBoxButtons.OK,MessageBoxIcon.Information);
				}
			}catch(Exception ex) {
				MessageBox.Show(ex.Message);
			}

		}
	}
}