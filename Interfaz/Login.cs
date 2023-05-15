using Modelos;
using Negocios;
using System.Data;
namespace Interfaz
{
	public partial class Login : Form
	{
		private List<Rol> Rols { get; set; }
		public Login()
		{
			InitializeComponent();
			CargarCredenciales();
		}

		private void label3_Click(object sender, EventArgs e)
		{

		}
		private async Task CargarCredenciales()
		{
			try
			{

			}catch(Exception f)
			{

			}
		}

		private async Task RecordarCredenciales()
		{
			try
			{

			}
			catch (Exception f)
			{

			}
		}

		private async void btnIngresar_Click(object sender, EventArgs e)
		{
			RolUsuarioNegocio rolUsuarioNegocio = new();
			UsuarioNegocio usuarioNegocio = new();
			if (string.IsNullOrEmpty(txtUsuario.Text) || string.IsNullOrEmpty(txtContrasena.Text))
			{
				lblErrorMessage.ForeColor = Color.White;
				lblErrorMessage.Text = "Verifique los campos";
			}
			else
			{
				if (cbTipo.Text.Length == 0)
				{
					lblErrorMessage.ForeColor = Color.White;
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
							bool Autorizacion = usuarioNegocio.IniciarSesion(txtUsuario.Text, txtContrasena.Text);
							if (Autorizacion)
							{
								Temporal.UsuarioActivo = usuarioNegocio.ObtenerUsuario(txtUsuario.Text);
								Temporal.TipoLogin = "Vendedor";
								ModuloVentas moduloVentas = new();
								this.Hide();
								moduloVentas.ShowDialog();
								this.Close();
							}
							else
							{
								lblErrorMessage.ForeColor = Color.White;
								lblErrorMessage.Text = "Información incorrecta";
							}
						}
						else
						{
							lblErrorMessage.ForeColor = Color.White;
							lblErrorMessage.Text = "No posee permisos de Vendedor";
						}
					}
					else if (cbTipo.Text.Equals("Admin"))
					{
						int idRol = (from i in Rols where i.Nombre.Equals("Admin") select i.RolId).FirstOrDefault();
						bool PermisoDeRol = rolUsuarioNegocio.VerificarRol(txtUsuario.Text, idRol);
						if (PermisoDeRol)
						{
							bool Autorizacion = usuarioNegocio.IniciarSesion(txtUsuario.Text, txtContrasena.Text);
							if (Autorizacion)
							{
								Temporal.UsuarioActivo = usuarioNegocio.ObtenerUsuario(txtUsuario.Text);
								Temporal.TipoLogin = "Administrador";
								ModuloAdministrador moduloAdministrador = new();
								this.Hide();
								moduloAdministrador.ShowDialog();
								this.Close();
							}
							else
							{
								lblErrorMessage.ForeColor = Color.White;
								lblErrorMessage.Text = "Información incorrecta";
							}
						}
						else
						{
							lblErrorMessage.ForeColor = Color.White;
							lblErrorMessage.Text = "No posee permisos de administrador";
						}

					}
				}
			}
		}

		private void Login_Load(object sender, EventArgs e)
		{
			var conexion = Negocio.ComunNegocios.VerificarConexion();
			if (conexion)
			{
				CargarRoles();
			}
			else
			{
				MessageBox.Show("No se puede conectar con la Base de Datos...\nVerifica tu conexion", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				this.Close();
			}


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
