using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Modelos;

namespace Negocio
{
	public class OfertaNegocio
	{

		public bool CrearOferta(Oferta ofertaNueva, out int idOferta)
		{
			try
			{
				using (var db = new DBContextProyectosAsfaltos())
				{
					db.Ofertas.Add(ofertaNueva);
					db.SaveChanges();
					idOferta = (from o in db.Ofertas				
								where o.AutorPrespuesto == ofertaNueva.AutorPrespuesto && o.Monto == ofertaNueva.Monto
								orderby o.OfertaId descending
								select o.OfertaId).FirstOrDefault();

				}				
				return true;
			}catch (Exception ex)
			{
				idOferta= 0;
				return false;
			}
		}
		public Dictionary<int, string> DiccionarioOfertas(int año = 0)
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
				return null;
			}

		}


		public List<Oferta> ListaOfertasPorAño(int ano = 0)
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
				return null;
			}

		}
		public List<Oferta> ListaOfertas(int idEncargado = 0)
		{
			try
			{
				List<Oferta> Ofertas = new List<Oferta>();
				using (var db = new DBContextProyectosAsfaltos())
				{
					Ofertas = db.Ofertas.Where(O => O.UsuarioId == idEncargado)
						.OrderByDescending(O => O.OfertaId).ToList();
				}
				return Ofertas;
			}
			catch (Exception e)
			{
				return null;
			}
		}
		public List<Oferta> ListaOfertas()
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
				return null;
			}
		}
	}
}
