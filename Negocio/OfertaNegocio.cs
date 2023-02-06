using Microsoft.EntityFrameworkCore;
using System.Linq;
using Modelos;

namespace Negocio
{
	/// <summary>
	/// Clase encargada de la logica y negociar los cambios con la base de datos
	/// </summary>
	public class OfertaNegocio
	{

		/// <summary>
		/// Realiza la busqueda de la informaci[on dada
		/// </summary>
		/// <param name="numeroOferta"></param>
		/// <param name="Cliente"></param>
		/// <returns></returns>
		public List<Oferta> BuscarOferta(int numeroOferta = 0, string Cliente = "")
		{
			try
			{
				List<Oferta> lista = new List<Oferta>();
				using(var db = new DBContextProyectosAsfaltos())
				{
					if(numeroOferta > 0 && !string.IsNullOrEmpty(Cliente))
					{
						lista = (from i in db.Ofertas
								 where i.OfertaId== numeroOferta && i.Cliente.Contains(Cliente)
								 orderby i.OfertaId descending
								 select i).Include(V=>V.Encargado).ToList();

					}
					else if (numeroOferta == 0 && !string.IsNullOrEmpty(Cliente))
					{
						lista = (from i in db.Ofertas
								 where  i.Cliente.Contains(Cliente)
								 orderby i.OfertaId descending
								 select i).Include(V => V.Encargado).ToList();

					}
					else if (numeroOferta > 0 && string.IsNullOrEmpty(Cliente))
					{
						lista = (from i in db.Ofertas
								 where i.OfertaId == numeroOferta
								 orderby i.OfertaId descending
								 select i).Include(V => V.Encargado).ToList();
					}
					else
					{
						return lista;
					}
					return lista;
				}
			}catch(Exception ex)
			{
				return new List<Oferta>();
			}
		}

		public int ObtenerUltimoId()
		{
			try
			{
				int Numero = -1;
				using(var db = new DBContextProyectosAsfaltos())
				{
					Numero = (from i in db.Ofertas
							  orderby i.OfertaId descending
							  select i.OfertaId).FirstOrDefault();
				}
				return Numero;
			}catch (Exception ex)
			{
				return -1;
			}
		}

		/// <summary>
		/// Registra una nueva oferta en la base de datos
		/// </summary>
		/// <param name="ofertaNueva">Objeto de tipo Oferta con la información base</param>
		/// <param name="idOferta">Id de la Oferta Ingresada. Si presenta error el id por defecto será 0 </param>
		/// <returns>True si logra insertar la oferta, false si presenta error</returns>
		public bool CrearOferta(Oferta ofertaNueva, out int idOferta)
		{
			try
			{
				int idTmp = ObtenerUltimoId();
				using (var db = new DBContextProyectosAsfaltos())
				{					
					if(idTmp != -1)
					{
						ofertaNueva.OfertaId = idTmp+1;
						db.Ofertas.Add(ofertaNueva);
						db.SaveChanges();
						idOferta = (from o in db.Ofertas
									where o.AutorPrespuesto == ofertaNueva.AutorPrespuesto && o.Monto == ofertaNueva.Monto
									orderby o.OfertaId descending
									select o.OfertaId).FirstOrDefault();
					}
					else
					{
						idOferta = 0;
						return false;
					}
				}
				return true;
			}
			catch (Exception ex)
			{
				Console.WriteLine(ex.Message);
				idOferta = 0;
				return false;
			}
		}

		/// <summary>
		/// Crea un diccionario con el nombre del cliente y el numero de oferta existente
		/// </summary>
		/// <param name="año"></param>
		/// <returns></returns>
		public async Task<Dictionary<int, string>?> DiccionarioOfertasAsync(int año = 0)
		{
			try
			{
				Dictionary<int, string> keyValuePairs = new();
				using (var db = new DBContextProyectosAsfaltos())
				{
					keyValuePairs = await (from i in db.Ofertas
										   where i.Fecha.Year == DateTime.Today.Year && (i.Fecha.Month == DateTime.Today.Month || i.Fecha.Month == DateTime.Today.AddMonths(-1).Month)
										   orderby i.OfertaId descending
										   select i).ToDictionaryAsync(O => O.OfertaId, O => O.Cliente);
				}
				return keyValuePairs;
			}
			catch (Exception ex)
			{
				Console.WriteLine(ex.Message);
				return null;
			}

		}


		public Dictionary<int, string>? DiccionarioOfertas(int año = 0)
		{
			try
			{
				Dictionary<int, string> keyValuePairs = new();
				using (var db = new DBContextProyectosAsfaltos())
				{
					keyValuePairs = (from i in db.Ofertas
									 where i.Fecha.Year == DateTime.Today.Year && (i.Fecha.Month == DateTime.Today.Month || i.Fecha.Month == DateTime.Today.AddMonths(-1).Month)
									 orderby i.OfertaId descending
									 select i).ToDictionary(O => O.OfertaId, O => O.Cliente);
				}
				return keyValuePairs;
			}
			catch (Exception ex)
			{
				Console.WriteLine(ex.Message);
				return null;
			}

		}


		public async Task<List<Oferta>?> ListaOfertasPorAñoAsync(int ano = 0)
		{
			try
			{
				List<Oferta> lista = new List<Oferta>();
				if (ano != 0)
				{
					using (var db = new DBContextProyectosAsfaltos())
					{
						lista = await (from i in db.Ofertas
									   where i.Fecha.Year == ano
									   orderby i.OfertaId descending
									   select i).Include(O => O.Encargado).ToListAsync();
					}
				}
				else
				{
					using (var db = new DBContextProyectosAsfaltos())
					{
						lista = await (from i in db.Ofertas
									   orderby i.OfertaId descending
									   where i.Fecha.Year == DateTime.Today.Year
									   select i).Include(O => O.Encargado).ToListAsync();
					}
				}
				return lista;
			}
			catch (Exception f)
			{
				Console.WriteLine(f.Message);
				return null;
			}

		}
		public List<Oferta>? ListaOfertasPorAño(int ano = 0)
		{
			try
			{
				List<Oferta> lista = new List<Oferta>();
				if (ano != 0)
				{
					using (var db = new DBContextProyectosAsfaltos())
					{
						lista = (from i in db.Ofertas
								 where i.Fecha.Year == ano
								 orderby i.OfertaId descending
								 select i).ToList();
					}
				}
				else
				{
					using (var db = new DBContextProyectosAsfaltos())
					{
						lista = (from i in db.Ofertas
								 orderby i.OfertaId descending
								 where i.Fecha.Year == DateTime.Today.Year
								 select i).ToList();
					}
				}
				return lista;
			}
			catch (Exception f)
			{
				Console.WriteLine(f.Message);
				return null;
			}

		}

		public List<Oferta> BuscarOferta(string? cliente = null, string? NumeroOferta = null, string? Vendedor = null)
		{
			if (cliente != null && NumeroOferta != null && Vendedor != null)
			{

			}
			else if (cliente == null && NumeroOferta != null && Vendedor != null)
			{

			}
			else if (cliente != null && NumeroOferta != null && Vendedor != null)
			{

			}
			throw new NotImplementedException();
		}




		public async Task<List<Oferta>?> ListaOfertasAsync()
		{
			try
			{
				List<Oferta> Ofertas = new List<Oferta>();
				using (var db = new DBContextProyectosAsfaltos())
				{
					Ofertas = await db.Ofertas.OrderByDescending(O => O.OfertaId).Include(O => O.Encargado).Take(100).ToListAsync();
				}
				return Ofertas;
			}
			catch (Exception e)
			{
				Console.WriteLine(e);	
				return null;
			}
		}
		public List<Oferta>? ListaOfertas()
		{
			try
			{
				List<Oferta> Ofertas = new List<Oferta>();
				using (var db = new DBContextProyectosAsfaltos())
				{
					Ofertas = db.Ofertas.OrderByDescending(O => O.OfertaId).Include(O => O.Encargado).ToList();
				}
				return Ofertas;
			}
			catch (Exception e)
			{
				Console.WriteLine(e);
				return null;
			}
		}
	}
}
