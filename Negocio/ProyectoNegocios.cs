using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client;
using Modelos;

namespace Negocios
{
	public class ProyectoNegocios
	{
		private DBContextProyectosAsfaltos dBContext = new DBContextProyectosAsfaltos();


		public async Task<bool> DesactivarProyectoAsync(int ProyectoId)
		{
			try
			{
				var Proyecto = ObtenerProyecto(ProyectoId);
				if (Proyecto != null)
				{
					Proyecto.Enable = false;
					using (var db = new DBContextProyectosAsfaltos())
					{
						db.Proyectos.Update(Proyecto);
						db.SaveChangesAsync();
					}
					return true;
				}
				else
				{
					return false;
				}
			}
			catch (Exception f)
			{
				return false;
			}
		}

		public bool DesactivarProyecto(int ProyectoId)
		{
			try
			{
				var Proyecto = ObtenerProyecto(ProyectoId);
				if (Proyecto != null)
				{
					Proyecto.Enable = false;
					using (var db = new DBContextProyectosAsfaltos())
					{
						db.Proyectos.Update(Proyecto);
						db.SaveChanges();
					}
					return true;
				}
				else
				{
					return false;
				}
			}
			catch (Exception f)
			{
				return false;
			}
		}


		public bool ActualizarProyecto(Proyecto proyecto)
		{
			try
			{
				using (var db = new DBContextProyectosAsfaltos())
				{
					db.Proyectos.Update(proyecto);
					db.SaveChanges();
				}
				return true;
			}
			catch (Exception ex)
			{
				Console.WriteLine(ex.Message);
				return false;
			}
		}

		public bool CrearProyecto(Proyecto proyecto, out int idProyecto)
		{
			try
			{
				using (var db = new DBContextProyectosAsfaltos())
				{
					db.Proyectos.Add(proyecto);
					db.SaveChanges();
					idProyecto = (from pro in db.Proyectos
								  where (pro.Autor == proyecto.Autor) && (pro.OfertaId == proyecto.OfertaId)
								  orderby pro.ProyectoId descending
								  select pro.ProyectoId).FirstOrDefault();
				}
				return true;
			}
			catch (Exception ex)
			{
				idProyecto = -1;
				return false;
			}
		}

		public async Task<List<Proyecto>> ListaProyectos(int idEncargado)
		{
			try
			{
				List<Proyecto> proyectos = new List<Proyecto>();
				using (var db = dBContext)
				{
					proyectos = await (from proye in db.Proyectos
									   where proye.UsuarioId == idEncargado && proye.Enable == true
									   orderby proye.ProyectoId descending
									   select proye).Include(P => P.Vendedor).ToListAsync();
				}
				return proyectos;
			}
			catch (Exception f)
			{
				return null;
			}
		}

		
		public async Task<List<Proyecto>> ListarProyectoAsync()
		{
			try
			{
				List<Proyecto> proyectos = new List<Proyecto>();
				using (var db = dBContext)
				{
					proyectos = await (from proye in db.Proyectos
								 orderby proye.ProyectoId descending
								 select proye).Include(P => P.Vendedor).ToListAsync();
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
				using (var db = dBContext)
				{
					proyectos = (from proye in db.Proyectos
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
