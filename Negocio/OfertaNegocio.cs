using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Modelos;

namespace Negocio
{
	public class OfertaNegocio
	{
		public Dictionary<int,string> DiccionarioOfertas(int año = 0)
		{
			try
			{
				Dictionary<int,string> keyValuePairs= new Dictionary<int,string>();
				using(var db = new DBContextProyectosAsfaltos())
				{

				}
			}catch (Exception ex)
			{
				return null;
			}

		}
		public List<Oferta> ListaOfertasPorAño (int ano = 0)
		{
			try{
				List<Oferta> lista = new List<Oferta>();
				if (ano != 0)
				{
					using(var db = new DBContextProyectosAsfaltos())
					{
						lista = (from i in db.Ofertas
								 where i.Fecha.Year == ano
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
			catch(Exception f)
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
					Ofertas = db.Ofertas.Where(O=>O.UsuarioId ==idEncargado)
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
					Ofertas = db.Ofertas.OrderByDescending(O=>O.OfertaId).Include(O=>O.Encargado).ToList();	
				}
				return Ofertas;	
			}catch(Exception e)
			{
				return null;
			}
		}
	}
}
