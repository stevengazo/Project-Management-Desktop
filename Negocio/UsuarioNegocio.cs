using Microsoft.EntityFrameworkCore;
using Modelos;
using System.Security.Cryptography;
using System.Text;

namespace Negocios
{
	public class UsuarioNegocio
	{


		public async Task<List<Usuario>?> ListarVendedoresAsync()
		{
			try
			{
				List<Usuario> Vendedores = new();
				using (var db = new DBContextProyectosAsfaltos())
				{
					Vendedores = await (from usuario in db.Usuarios
										join rolesUsuario in db.RolUsuarios on usuario.UsuarioId equals rolesUsuario.UsuarioId
										where rolesUsuario.RolId == 2 && usuario.Activo == true
										select usuario
								  ).Distinct().ToListAsync();
				}
				return Vendedores;
			}
			catch (Exception f)
			{
				Console.WriteLine(f.Message);
				return null;
			}
		}

		public List<Usuario> ListarVendedores()
		{
			try
			{
				List<Usuario> Vendedores = new();
				using (var db = new DBContextProyectosAsfaltos())
				{
					Vendedores = (from usuario in db.Usuarios
								  join rolesUsuario in db.RolUsuarios on usuario.UsuarioId equals rolesUsuario.UsuarioId
								  where rolesUsuario.RolId == 2 && usuario.Activo == true
								  select usuario
								  ).ToList();
				}
				return Vendedores;
			}
			catch (Exception f)
			{
				Console.WriteLine(f.Message);
				return null;
			}
		}


		public bool ActualizarUsuario(Usuario usuario)
		{
			try
			{
				using (var db = new DBContextProyectosAsfaltos())
				{
					db.Usuarios.Update(usuario);
					db.SaveChanges();
				}
				return true;
			}
			catch (Exception f)
			{
				Console.WriteLine(f.Message);
				return false;
			}
		}

		public bool CambiarContraseña(int idUsuario, string contraseña)
		{
			try
			{
				Usuario usuario = ObtenerUsuario(idUsuario);
				if (usuario != null)
				{
					using (var md6Hash = MD5.Create())
					{
						var fuente = Encoding.UTF8.GetBytes(contraseña);
						var hashBytes = md6Hash.ComputeHash(fuente);
						var hash = BitConverter.ToString(hashBytes).Replace("-", string.Empty);
						usuario.HashContraseña = hash;
					}
					using (var db = new DBContextProyectosAsfaltos())
					{
						db.Usuarios.Update(usuario);
						db.SaveChanges();
					}
					return true;
				}
				else
				{
					return false;
				}

			}
			catch (Exception e)
			{
				Console.WriteLine(e.Message);
				return false;
			}
		}
		public bool CrearUsuario(Usuario _usuario, out int UsuarioId)
		{
			try
			{
				string contrasena = _usuario.HashContraseña;
				using (var md6Hash = MD5.Create())
				{
					var fuente = Encoding.UTF8.GetBytes(contrasena);
					var hashBytes = md6Hash.ComputeHash(fuente);
					var hash = BitConverter.ToString(hashBytes).Replace("-", string.Empty);
					_usuario.HashContraseña = hash;
				}
				using var db = new DBContextProyectosAsfaltos();
				db.Usuarios.Add(_usuario);
				db.SaveChanges();
				UsuarioId = (from i in db.Usuarios where i.Login == _usuario.Login select i.UsuarioId).FirstOrDefault();
				return true;
			}
			catch (Exception ex)
			{
				Console.WriteLine(ex.Message);
				UsuarioId = 0;
				return false;
			}
		}

		/// <summary>
		/// Comprueba si un username ya esta registrado en la DB
		/// </summary>
		/// <param name="login">logins para comprobar</param>
		/// <returns></returns>
		public bool ComprobarLogin(string login)
		{
			try
			{
				using (var db = new DBContextProyectosAsfaltos())
				{
					var resultado = (from i in db.Usuarios
									 where i.Login.ToLower() == login.ToLower()
									 select i).FirstOrDefault();
					if (resultado != null)
					{
						return true;
					}
					else
					{
						return false;
					}
				}
			}
			catch (Exception r)
			{
				Console.WriteLine(r.Message);
				return true;
			}
		}
		public bool ComprobarId(int idUsuario)
		{
			throw new NotImplementedException();
		}
		public Usuario? ObtenerUsuario(string login)
		{
			try
			{
				using (var db = new DBContextProyectosAsfaltos())
				{
					var s = (from i in db.Usuarios
							 where i.Login.ToLower() == login.ToLower()
							 select i).FirstOrDefault();
					return s;
				}
			}
			catch (Exception ex)
			{
				Console.WriteLine(ex.Message);
				return null;
			}
		}
		public Usuario ObtenerUsuario(int _idUsuario)
		{
			try
			{
				using (var db = new DBContextProyectosAsfaltos())
				{
					var s = (from i in db.Usuarios
							 where i.UsuarioId == _idUsuario
							 select i).FirstOrDefault();
					return s;
				}
			}
			catch (Exception ex)
			{
				Console.WriteLine(ex.Message);
				return new();
			}
		}

		public bool IniciarSesion(string login, string password)
		{
			try
			{
				int cuenta = 0;
				var contrasena = password;
				using (var md6Hash = MD5.Create())
				{
					var fuente = Encoding.UTF8.GetBytes(contrasena);
					var hashBytes = md6Hash.ComputeHash(fuente);
					var hash = BitConverter.ToString(hashBytes).Replace("-", string.Empty);
					contrasena = hash;
				}
				using (var db = new DBContextProyectosAsfaltos())
				{
					cuenta = (
							from i in db.Usuarios
							where i.Login.ToUpper() == login.ToUpper() && i.HashContraseña == contrasena && i.Activo == true
							select i
						).Count();

				}
				if (cuenta > 0)
				{
					return true;
				}
				else
				{
					return false;
				}
			}
			catch (Exception ex)
			{
				Console.WriteLine(ex.Message);
				return false;
			}
		}
		public List<Usuario>? ListarUsuarios()
		{
			try
			{
				List<Usuario> usuarios = new List<Usuario>();
				using (var db = new DBContextProyectosAsfaltos())
				{
					usuarios = (from usuario in db.Usuarios
								orderby usuario.Activo descending
								select usuario).ToList();
					foreach (var item in usuarios)
					{
						item.HashContraseña = string.Empty;
					}
				}
				return usuarios;
			}
			catch (Exception ex)
			{
				Console.WriteLine(ex.ToString());
				return null;
			}
		}

		public async Task<List<Usuario>?> ListarUsuariosAsync()
		{
			try
			{
				List<Usuario> usuarios = new List<Usuario>();
				using (var db = new DBContextProyectosAsfaltos())
				{
					usuarios = await (from usuario in db.Usuarios
									  orderby usuario.Activo descending
									  select usuario).ToListAsync();
					foreach (var item in usuarios)
					{
						item.HashContraseña = string.Empty;
					}
				}
				return usuarios;
			}
			catch (Exception ex)
			{
				Console.WriteLine(ex.ToString());
				return null;
			}
		}

	}
}
