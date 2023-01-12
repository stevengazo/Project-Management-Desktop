using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;
using Modelos;

namespace Negocios
{
	public class UsuarioNegocio
	{
		private DBContextProyectosAsfaltos dBContext = new DBContextProyectosAsfaltos();

		public List<Usuario> ListarUsuarios()
		{
			try
			{
				List<Usuario> usuarios= new List<Usuario>();
				using( var db = dBContext)
				{
					usuarios = (from usuario in db.Usuarios
								select usuario).ToList();
					foreach (var item in usuarios)
					{
						item.HashContraseña = string.Empty;
					}
				}
				return usuarios;
			}catch(Exception ex)
			{
				Console.WriteLine(ex.ToString());
				return null;
			}
		}
	}
}
