using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Modelos;

namespace Negocios
{
	public  class ProyectoNegocios
	{
		private  DBContextProyectosAsfaltos dBContext = new DBContextProyectosAsfaltos();



		public bool CrearProyecto(Proyecto proyecto, out int idProyecto)
		{
			try
			{
				using(var db = new DBContextProyectosAsfaltos())
				{
					db.Proyectos.Add(proyecto);
					db.SaveChanges();
					idProyecto = (from pro in db.Proyectos
								  where (pro.Autor == proyecto.Autor) && (pro.OfertaId == proyecto.OfertaId)
								  orderby pro.ProyectoId descending
								  select pro.ProyectoId).FirstOrDefault();
				}
				return true;
			}catch (Exception ex)
			{
				idProyecto = -1;
				return false;
			}
		}
		public List<Proyecto> ListaProyectos(int idEncargado)
		{
			try
			{
				List<Proyecto> proyectos = new List<Proyecto>();
				using (var db = dBContext)
				{
					proyectos = (from proye in db.Proyectos
								 where proye.UsuarioId == idEncargado && proye.Enable == true
								 orderby proye.ProyectoId descending
								 select proye).Include(P => P.Vendedor).ToList();
				}
				return proyectos;
			}
			catch (Exception f)
			{
				return null;
			}
		}
		public List<Proyecto> ListaProyectos()
		{
			try
			{
				List<Proyecto> proyectos = new List<Proyecto>();
				using( var db = dBContext)
				{
					proyectos = (from proye in db.Proyectos
								 orderby proye.ProyectoId descending
								 select proye).Include(P=>P.Vendedor).ToList();
				}
				return proyectos;
			}catch (Exception f)
			{
				return null;
			}
		}
		public Proyecto ObtenerProyecto(int id)
		{
			try
			{
				Proyecto proyectos = new();
				using (var db = dBContext)
				{
					proyectos = (from proye in db.Proyectos
								 where proye.ProyectoId == id
								 select proye).Include(P => P.Vendedor).FirstOrDefault();
				}
				return proyectos;
			}
			catch (Exception f)
			{
				return null;
			}
		}
	}
}
