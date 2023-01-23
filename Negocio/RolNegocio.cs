﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelos;

namespace Negocios
{

	public class RolNegocio
	{
		private DBContextProyectosAsfaltos dBContext = new DBContextProyectosAsfaltos();

		public List<Rol> ListaDeRoles()
		{
			try
			{
				using(var db = dBContext)
				{
					return db.Roles.ToList();
				}
			}catch(Exception ex) {
				Console.Write(ex.ToString());
				return null;
			}
		}
	}
}
