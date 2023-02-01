using Modelos;

namespace Negocios
{
	public class RolUsuarioNegocio
	{
		private DBContextProyectosAsfaltos dBContext = new DBContextProyectosAsfaltos();

		public bool AgregarRolUsuario(RolUsuario item)
		{
			try
			{
				using (var db = new DBContextProyectosAsfaltos())
				{
					db.RolUsuarios.Add(item);
					db.SaveChanges();
				}
				return true;
			}
			catch (Exception f)
			{
				return false;
			}
		}

		public bool VerificarRol(string login, int idRol)
		{
			try
			{
				using (var db = dBContext)
				{
					var query = (
							from item in db.RolUsuarios
							join usuario in db.Usuarios on item.UsuarioId equals usuario.UsuarioId
							where usuario.Login.ToUpper().Equals(login.ToUpper()) && item.RolId == idRol
							select item
								 ).FirstOrDefault();
					if (query != null)
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


		public bool VerificarRol(int idUsuario, int idRol)
		{
			try
			{
				using (var db = dBContext)
				{
					var query = (from item in db.RolUsuarios
								 where item.RolUsuarioId == idUsuario && item.RolUsuarioId == idRol
								 select item
								 ).FirstOrDefault();
					if (query != null)
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
	}
}
