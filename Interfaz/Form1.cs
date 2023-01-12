using Modelos;
using Negocios;
using System.Data;

namespace Interfaz
{
	public partial class Form1 : Form
	{		

		public Form1()
		{
			InitializeComponent();
		}

		private void agregarRazónSocialToolStripMenuItem_Click(object sender, EventArgs e)
		{
			AgregarCliente tmp1= new AgregarCliente();
			tmp1.ShowDialog();
			// Actualizar combobox
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
		}

		private void CargarVendedores()
		{
			try
			{
				var VendedoresNegocios = new VendedorNegocio();
				var listaVendedores = VendedoresNegocios.ListarVendedores();
				foreach (Vendedor i in listaVendedores) { 
					cbVendedores.Items.Add(i.Nombre);
				}

			}catch (Exception ex) {
				MessageBox.Show(ex.Message);
			}

		}
		private void CargarTabla()
		{
			var proyectosNegocio = new ProyectoNegocios();
			List<Proyecto> proyectos = proyectosNegocio.ListaProyectos();
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
			}
		}

		private void razonesSocialesToolStripMenuItem_Click(object sender, EventArgs e)
		{
			ListarCliente tmp = new();
			tmp.ShowDialog();
		}
	}
}