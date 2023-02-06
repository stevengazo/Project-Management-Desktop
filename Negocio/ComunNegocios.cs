using Modelos;

namespace Negocio
{
	public static class ComunNegocios
	{
		public static bool VerificarConexion()
		{
			using (var db = new DBContextProyectosAsfaltos())
			{
				try
				{
					var dbconn = db.Database.CanConnect();
					return dbconn;
				}
				catch (Exception r)
				{
					Console.WriteLine(r.Message);
					return false;
				}
			}

		}
	}
}
