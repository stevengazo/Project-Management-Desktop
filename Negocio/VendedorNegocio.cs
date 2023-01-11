using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;
using Modelos;

namespace Negocios
{
	public class VendedorNegocio
	{
		private  DBContextProyectosAsfaltos dbContext { get; set; } = new DBContextProyectosAsfaltos();

		public bool CrearVendedor(Vendedor vendedor)
		{
			try
			{
				using( var db = dbContext )
				{
					dbContext.Vendedores.Add( vendedor );
					dbContext.SaveChanges();
				}
				return true;
			}
			catch (Exception r)
			{
				return false;
			}
		}

	}
}
