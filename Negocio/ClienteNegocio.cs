using Modelos;

namespace Negocio
{
    public class ClienteNegocio
    {
        /// <summary>
        /// Lista los clientes existentes en la DB de forma asincrona
        /// </summary>
        /// <returns>Lista de clientes</returns>
        public Task<Cliente>? ListaClientesAsync()
        {
            try
            {
                List<Cliente> clientes = new List<Cliente>();
                throw new NotImplementedException();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }
        }

        /// <summary>
        /// Lista los clientes registrados en la DB
        /// </summary>
        /// <returns></returns>
        public List<Cliente>? ListaClientes()
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
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }
        }

    }
}
