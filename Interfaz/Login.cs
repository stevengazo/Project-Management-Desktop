using Microsoft.VisualBasic.ApplicationServices;
using Modelos;
using Negocios;
using System.Data;
using System.Xml;
using System.Xml.Linq;

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
				string urlArchivo = Path.Combine(Directory.GetCurrentDirectory(), "temporales.xml");
				if (File.Exists(urlArchivo))
				{
					var data = new FileStream(urlArchivo, FileMode.Open, FileAccess.Read);
					var documento = new XmlDataDocument();
					documento.Load(data);
					XmlNodeList nodeList = documento.GetElementsByTagName("root");
					string Usuario = string.Empty;
					string Contraseña = string.Empty;
					foreach (XmlNode item in nodeList)
					{
						Usuario = item.SelectSingleNode("Usuario").InnerText.ToString();
						Contraseña = item.SelectSingleNode("Contraseña").InnerText.ToString();
					}
					txtContrasena.Text = Contraseña;
					txtUsuario.Text = Usuario;
					checkBoxContrasena.Checked = true;
				}
				else
				{
					XDocument document = new XDocument(
													new XDeclaration("1.0", "utf-8", "yes"),
													new XComment("XML from plain code"),

													new XElement("root",
														new XElement("Usuario", string.Empty),
														new XElement("Contraseña", string.Empty)
														));
					document.Save(urlArchivo);
				}
			}
			catch (Exception f)
			{
				MessageBox.Show(f.Message);
			}

		}

		private async Task RecordarCredenciales()
		{
			try
			{

				string urlArchivo = Path.Combine(Directory.GetCurrentDirectory(), "temporales.xml");
				string usuario = txtUsuario.Text;
				string contraseña = txtContrasena.Text;
				if (File.Exists(urlArchivo))
				{
					File.Delete(urlArchivo);
				}
				if (checkBoxContrasena.Checked)
				{
					XDocument document = new XDocument(
														new XDeclaration("1.0", "utf-8", "yes"),
														new XComment("XML from plain code"),

														new XElement("root",
															new XElement("Usuario", usuario),
															new XElement("Contraseña", contraseña)
															));
					document.Save(urlArchivo);
				}
				else
				{
					XDocument document = new XDocument(
														new XDeclaration("1.0", "utf-8", "yes"),
														new XComment("XML from plain code"),

														new XElement("root",
															new XElement("Usuario", string.Empty),
															new XElement("Contraseña", string.Empty)
															));
					document.Save(urlArchivo);
				}




			}
			catch (Exception f)
			{
				MessageBox.Show(f.Message, "Error SaveCredentias");
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
								RecordarCredenciales();
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
								RecordarCredenciales();
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
