using Microsoft.EntityFrameworkCore;
using Modelos;

namespace Negocio
{
    /// <summary>
    /// Clase encargada de la logica y negociar los cambios con la base de datos
    /// </summary>
    public class OfertaNegocio
    {


        public bool ActualizarOferta(Oferta oferta, out int idOferta)
        {
            try
            {
                using (var db = new DBContextProyectosAsfaltos())
                {
                    db.Ofertas.Update(oferta);
                    db.SaveChanges();
                    idOferta = oferta.OfertaId;
                    return true;
                }
            }
            catch (Exception ex)
            {
                idOferta = -1;
                return false;
            }
        }

        public Oferta ObtenerOferta(int numeroOferta = 0)
        {
            try
            {
                if (numeroOferta > 0)
                {
                    using (var db = new DBContextProyectosAsfaltos())
                    {
                        var oferta = (from o in db.Ofertas
                                      where o.OfertaId == numeroOferta
                                      select o).Include(E => E.Encargado).FirstOrDefault();
                        return oferta;
                    }
                }
                return null;
            }
            catch (Exception f)
            {
                Console.Error.WriteLine(f.ToString());
                return new();
            }
        }

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
                using (var db = new DBContextProyectosAsfaltos())
                {
                    if (numeroOferta > 0 && !string.IsNullOrEmpty(Cliente))
                    {
                        lista = (from i in db.Ofertas
                                 where i.OfertaId == numeroOferta && i.Cliente.Contains(Cliente)
                                 orderby i.OfertaId descending
                                 select i).Include(V => V.Encargado).ToList();

                    }
                    else if (numeroOferta == 0 && !string.IsNullOrEmpty(Cliente))
                    {
                        lista = (from i in db.Ofertas
                                 where i.Cliente.Contains(Cliente)
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
            }
            catch (Exception ex)
            {
                return new List<Oferta>();
            }
        }


        public List<Oferta> BuscarOferta(int numeroOferta = 0, string Cliente = "", int idUser = 0)
        {
            try
            {
                List<Oferta> lista = new List<Oferta>();
                using (var db = new DBContextProyectosAsfaltos())
                {
                    if (numeroOferta > 0 && !string.IsNullOrEmpty(Cliente))
                    {
                        lista = (from i in db.Ofertas
                                 where i.OfertaId == numeroOferta && i.Cliente.Contains(Cliente) && i.UsuarioId == idUser
                                 orderby i.OfertaId descending
                                 select i).Include(V => V.Encargado).ToList();

                    }
                    else if (numeroOferta == 0 && !string.IsNullOrEmpty(Cliente))
                    {
                        lista = (from i in db.Ofertas
                                 where i.Cliente.Contains(Cliente) && i.UsuarioId == idUser
                                 orderby i.OfertaId descending
                                 select i).Include(V => V.Encargado).ToList();

                    }
                    else if (numeroOferta > 0 && string.IsNullOrEmpty(Cliente))
                    {
                        lista = (from i in db.Ofertas
                                 where i.OfertaId == numeroOferta && i.UsuarioId == idUser
                                 orderby i.OfertaId descending
                                 select i).Include(V => V.Encargado).ToList();
                    }
                    else
                    {
                        return lista;
                    }
                    return lista;
                }
            }
            catch (Exception ex)
            {
                return new List<Oferta>();
            }
        }


        public int ObtenerUltimoId()
        {
            try
            {
                int Numero = -1;
                using (var db = new DBContextProyectosAsfaltos())
                {
                    Numero = (from i in db.Ofertas
                              orderby i.OfertaId descending
                              select i.OfertaId).FirstOrDefault();
                }
                return Numero;
            }
            catch (Exception ex)
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
                    if (idTmp != -1)
                    {
                        ofertaNueva.Concluida = false;
                        ofertaNueva.OfertaId = idTmp + 1;
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

      
        public Dictionary<int, string>? DiccionarioOfertas(int PlazoDias = 20)
        {
            try
            {
                Dictionary<int, string> keyValuePairs = new();
                var fecha = DateTime.Now.AddDays(-PlazoDias);
                using (var db = new DBContextProyectosAsfaltos())
                {
                    keyValuePairs = (from i in db.Ofertas
                                     where i.Fecha >= fecha
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

        public async Task<List<Oferta>?> ListaOfertasPorAñoAsync(int ano = 0, int idUsuario = 0)
        {
            try
            {
                List<Oferta> lista = new List<Oferta>();
                if (ano != 0)
                {
                    using (var db = new DBContextProyectosAsfaltos())
                    {
                        lista = await (from i in db.Ofertas
                                       where i.Fecha.Year == ano && i.UsuarioId == idUsuario
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
