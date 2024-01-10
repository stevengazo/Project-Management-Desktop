using Microsoft.EntityFrameworkCore;
using Modelos;

namespace Negocios
{
    public class ProyectoNegocios
    {
        private DBContextProyectosAsfaltos dBContext = new DBContextProyectosAsfaltos();


        public int ObtenerUltimoNumero()
        {
            try
            {
                var query = (from i in dBContext.Proyectos
                             orderby i.ProyectoId descending
                             select i.ProyectoId).FirstOrDefault();
                return query;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return -1;
            }
        }

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
                        await db.SaveChangesAsync();
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
                Console.WriteLine(f.Message);
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
                Console.WriteLine(f.Message);
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
                    var numeroProyecto = ObtenerUltimoNumero();
                    if (numeroProyecto > 0)
                    {
                        proyecto.ProyectoId = numeroProyecto + 1;
                    }
                    else
                    {
                        idProyecto = -1;
                        return false;
                    }
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
                Console.WriteLine(ex.Message);
                idProyecto = -1;
                return false;
            }
        }

        public async Task<List<Proyecto>?> ListaProyectos(int idEncargado)
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
                Console.WriteLine(f.Message);
                return null;
            }
        }

        public async Task<List<Proyecto>?> ListarProyectoAsync()
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
                Console.WriteLine(f.Message);
                return null;
            }
        }

        public List<Proyecto>? ListaProyectos()
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
                Console.WriteLine(f.Message);
                return null;
            }
        }
        public Proyecto? ObtenerProyecto(int id)
        {
            try
            {
                var proyectos = new Proyecto();
                using (var db = dBContext)
                {
                    proyectos = (from proye in db.Proyectos
                                 where proye.ProyectoId == id
                                 select proye)
                                 .Include(P => P.Vendedor)
                                 .Include(P=>P.Notas)
                                 .FirstOrDefault();
                }
                return proyectos;
            }
            catch (Exception f)
            {
                Console.WriteLine(f.Message);
                return null;
            }
        }
    }
}
