using Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
	public class ClienteNegocio
	{
		public List<Cliente> ListaClientes()
		{
			try
			{
				List<Cliente> clientes = new List<Cliente>();
				/*using (var db =new DBContextProyectosAsfaltos())
				{
					
					clientes = (from c in db.Clientes
								orderby c.ClienteName descending
								select c).ToList();	
				}*/
				throw new NotImplementedException();
				return clientes;
			}catch(Exception ex)
			{
				return null;
			}
		}
		
	}
}
