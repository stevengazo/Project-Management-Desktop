using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;
using Modelos;

namespace Negocios
{
	public class ClienteNegocio
	{
		private DBContextProyectosAsfaltos dBContext = new DBContextProyectosAsfaltos();


		public bool RegistrarCliente(Cliente cliente)
		{
			try
			{
				using (var db = dBContext)
				{
					db.Clientes.Add(cliente);
					db.SaveChanges();
					return true;
				}			
			}catch(Exception ex)
			{
				return false;
			}
		}
		public List<Cliente> ListarClientes()
		{
			try
			{
				List<Cliente> clientes= new List<Cliente>();
				using( var db = dBContext)
				{
					clientes = (
							from cliente in db.Clientes
							orderby cliente.RazonSocial descending
							select cliente
						).ToList();
				}
				return clientes;

			}catch(Exception ex)
			{
				Console.WriteLine(ex.ToString());
				return null;
			}
		}
	}
}
