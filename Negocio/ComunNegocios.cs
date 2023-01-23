using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelos;
using Datos;

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
					var dbconn =  db.Database.CanConnect();
					return dbconn;
				}
				catch (Exception r)
				{
					return false;
				}
			}
			
		}
	}
}
