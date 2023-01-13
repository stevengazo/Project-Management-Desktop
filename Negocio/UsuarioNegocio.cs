using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using Datos;
using Modelos;

namespace Negocios
{
	public class UsuarioNegocio
	{
		private DBContextProyectosAsfaltos dBContext = new DBContextProyectosAsfaltos();

		public bool IniciarSesion(string login, string password)
		{
			try
			{
				var contrasena = password;
				using (var md6Hash = MD5.Create())
				{
					var fuente = Encoding.UTF8.GetBytes(contrasena);
					var hashBytes = md6Hash.ComputeHash(fuente);
					var hash = BitConverter.ToString(hashBytes).Replace("-", string.Empty);
					contrasena = hash;
				}
				using (var db = dBContext)
				{
					var resultado = (
							from i in db.Usuarios
							where i.Nombre == login && i.HashContraseña == contrasena
							select i
						).Count();
					if (resultado > 0)
					{
						return true;
					}
					else
					{
						return false;
					}
				}
			}
			catch (Exception ex)
			{
				return false;
			}
		}
		public List<Usuario> ListarUsuarios()
		{
			try
			{
				List<Usuario> usuarios = new List<Usuario>();
				using (var db = dBContext)
				{
					usuarios = (from usuario in db.Usuarios
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
	}
}
