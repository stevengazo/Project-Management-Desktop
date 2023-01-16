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
		private List<Rol> Rols { get; set; }
		public Login()
		{
			InitializeComponent();
		}

		private void label3_Click(object sender, EventArgs e)
		{

		}

		private async void btnIngresar_Click(object sender, EventArgs e)
		{
			RolUsuarioNegocio rolUsuarioNegocio = new();
			UsuarioNegocio usuarioNegocio = new();
			if (string.IsNullOrEmpty(txtUsuario.Text) || string.IsNullOrEmpty(txtContrasena.Text))
			{
				lblErrorMessage.ForeColor = Color.Red;
				lblErrorMessage.Text = "Verifique los campos";
			}
			else
			{
				if (cbTipo.Text.Length == 0)
				{
					lblErrorMessage.ForeColor = Color.Red;
					lblErrorMessage.Text = "Seleccione un tipo de Ingreso";
				}
				else
				{
					if (cbTipo.Text.Equals("Vendedor"))
					{
						int idRol = (from i in Rols where i.Nombre.Equals("Vendedor") select i.RolId).FirstOrDefault();
						bool PermisoDeRol = rolUsuarioNegocio.VerificarRol(txtUsuario.Text, idRol);
						if (PermisoDeRol)
						{
							bool Autorizacion = await usuarioNegocio.IniciarSesion(txtUsuario.Text, txtContrasena.Text);
							if (Autorizacion)
							{
								Temporal.UsuarioActivo =  usuarioNegocio.ObtenerUsuario(txtUsuario.Text);
								ModuloVentas moduloVentas = new();
								this.Hide();
								moduloVentas.ShowDialog();
								this.Close();
							}
							else
							{
								lblErrorMessage.ForeColor = Color.Red;
								lblErrorMessage.Text = "Información incorrecta";
							}
						}
						else
						{
							lblErrorMessage.ForeColor = Color.Red;
							lblErrorMessage.Text = "Verifique los permisos de tipo Vendedor";
						}
					}
					else if (cbTipo.Text.Equals("Admin"))
					{
						int idRol = (from i in Rols where i.Nombre.Equals("Admin") select i.RolId).FirstOrDefault();
						bool PermisoDeRol = rolUsuarioNegocio.VerificarRol(txtUsuario.Text, idRol);
						if (PermisoDeRol)
						{
							bool Autorizacion = await usuarioNegocio.IniciarSesion(txtUsuario.Text, txtContrasena.Text);
							if (Autorizacion)
							{
								Temporal.UsuarioActivo = usuarioNegocio.ObtenerUsuario(txtUsuario.Text);
								ModuloAdministrador moduloAdministrador = new();
								this.Hide();
								moduloAdministrador.ShowDialog();
								this.Close();
							}
							else
							{
								lblErrorMessage.ForeColor = Color.Red;
								lblErrorMessage.Text = "Información incorrecta";
							}
						}
						else
						{
							lblErrorMessage.ForeColor = Color.Red;
							lblErrorMessage.Text = "Verifique los permisos de tipo Admin";
						}

					}
				}
			}
		}

		private void Login_Load(object sender, EventArgs e)
		{
			CargarRoles();
		}

		private void CargarRoles()
		{
			RolNegocio rolNegocio = new();
			Rols = rolNegocio.ListaDeRoles();
			if (Rols != null)
			{
				foreach (Rol i in Rols)
				{
					cbTipo.Items.Add(i.Nombre);
				}
			}
		}
	}
}
