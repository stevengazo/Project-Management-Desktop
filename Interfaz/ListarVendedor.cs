using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Negocios;
using Modelos;


namespace Interfaz
{
	public partial class ListarVendedor : Form
	{
		private List<Vendedor> vendedorList;	
		public ListarVendedor()
		{
			InitializeComponent();
		}

		private void ListarVendedor_Load(object sender, EventArgs e)
		{
			CargarVendedores();
		}

		private void CargarVendedores()
		{
			try
			{
				VendedorNegocio dataNegocios = new VendedorNegocio();
				vendedorList = dataNegocios.ListarVendedores();
				if (vendedorList.Count > 0)
				{
					DataTable data = new DataTable();
					data.Columns.Add("Id");
					data.Columns.Add("Nombre");


					foreach (Vendedor item in  vendedorList)
					{
						var tmp = new { item.VendedorId, item.Nombre };
						data.Rows.Add(
							tmp.VendedorId, tmp.Nombre);
					}
					dgvVendedores.DataSource = data;
				}
				else
				{
					MessageBox.Show("No se lograron obtener datos", "Informaci");
				}

			}
			catch (Exception ex) { 
				MessageBox.Show(ex.Message);
			}
		}
	}
}
