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
	public partial class Login : Form
	{
		public Login()
		{
			InitializeComponent();
		}

		private void label3_Click(object sender, EventArgs e)
		{

		}

		private void btnIngresar_Click(object sender, EventArgs e)
		{
			if( string.IsNullOrEmpty(txtUsuario.Text) || string.IsNullOrEmpty(txtContrasena.Text))
			{
				lblErrorMessage.ForeColor = Color.Red;
				lblErrorMessage.Text = "Verifique los campos";
			}
			else
			{
				lblErrorMessage.Text = string.Empty;
				UsuarioNegocio tmp = new UsuarioNegocio();
				var aprobado = tmp.IniciarSesion(txtUsuario.Text,txtContrasena.Text);
				if (aprobado)
				{
					Form1 tp = new Form1();
					this.Hide();
					tp.ShowDialog();				
					this.Close();
				}
				else
				{
					lblErrorMessage.ForeColor = Color.Red;
					lblErrorMessage.Text = "Datos incorrectos";
				}
			}
		}
	}
}
