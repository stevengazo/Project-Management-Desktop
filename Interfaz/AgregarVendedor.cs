using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Modelos;
using Negocios;

namespace Interfaz
{
	public partial class AgregarVendedor : Form
	{
		public AgregarVendedor()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void button2_Click(object sender, EventArgs e)
		{
			if (!string.IsNullOrEmpty(txtNombre.Text)){
				VendedorNegocio tmp = new();
				Vendedor nuevo = new Vendedor();
				nuevo.Nombre = txtNombre.Text;
				var resultado = tmp.CrearVendedor(nuevo);
				if(resultado)
				{
					MessageBox.Show("Vendedor Agregado", "INfo", MessageBoxButtons.OK);
					this.Close();
				}
				else
				{
					MessageBox.Show("Vendedor Agregado", "Error", MessageBoxButtons.OK);
				}
			}
		}
	}
}
