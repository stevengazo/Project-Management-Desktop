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

namespace Interfaz
{
	public partial class AgregarOferta : Form
	{
		private List<Usuario> usuarios= new List<Usuario>();
		public AgregarOferta()
		{
			InitializeComponent();
		}

		private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
		{

		}

		private void AgregarOferta_Load(object sender, EventArgs e)
		{
			CargarEncargados();
		}
		private void CargarEncargados()
		{
			try
			{
				UsuarioNegocio UsuarioNegocio = new UsuarioNegocio();
				usuarios = UsuarioNegocio.ListarVendedores();
				foreach (var item in usuarios)
				{
					cbEncargado.Items.Add(item.Nombre);
				}
			}catch(Exception ex) { 
				MessageBox.Show($"Error Interno: {ex.Message}","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);	
			}

		}
	}
}
