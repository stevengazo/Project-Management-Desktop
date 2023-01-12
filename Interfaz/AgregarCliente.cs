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
	public partial class AgregarCliente : Form
	{
		public AgregarCliente()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void btnAgregar_Click(object sender, EventArgs e)
		{
			try
			{
				Cliente clientetmp = new();
				int.TryParse(txtCedula.Text,out int resultado);
				if(resultado == 0)
				{
					MessageBox.Show("Verifique el numero de cedula, Ejmplo: 1111111", "advertencia", MessageBoxButtons.OK);
				}
				else
				{
					if( string.IsNullOrEmpty(txtNombreComercial.Text) || string.IsNullOrEmpty(txtRazon.Text) )
					{
						MessageBox.Show("Verifique el nombre y la razon social", "advertencia", MessageBoxButtons.OK);
					}
					else
					{
						clientetmp.Cedula = int.Parse(txtCedula.Text);
						clientetmp.NombreComercial = txtNombreComercial.Text;
						clientetmp.RazonSocial = txtRazon.Text;
						ClienteNegocio tmp = new();
						bool result = tmp.RegistrarCliente(clientetmp);
						if (result)
						{
							MessageBox.Show($"Cliente {clientetmp.NombreComercial} Agregado", "Informacion",MessageBoxButtons.OK,MessageBoxIcon.Information);
							this.Close();
						}
					}
				}

			}
			catch(Exception ex) { 
			}

		}
	}
}
