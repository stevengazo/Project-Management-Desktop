using Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public static class CotizacionNegocio
    {

        public static Cotizacion Get(int id)
        {
            using (var db = new DBContextProyectosAsfaltos())
            {
                return db.Cotizaciones.FirstOrDefault(i => i.CotizacionId == id);
            }
        }
        public static List<Cotizacion> UltimasCotizaciones(int PlazoDias = 30)
        {
            using (var db = new DBContextProyectosAsfaltos())
            {
                var fecha = DateTime.Today.AddDays(-PlazoDias);
                var data = db.Cotizaciones
                    .Where(i => i.Creación >= fecha)
                    .OrderByDescending(i => i.Creación)
                    .ToList();
                return data;
            }
        }
        public static List<Cotizacion> Listar()
        {
            using (var db = new DBContextProyectosAsfaltos())
            {
                return db.Cotizaciones.ToList();
            }
        }

        public static Cotizacion Add(Cotizacion c)
        {
            using (var db = new DBContextProyectosAsfaltos())
            {
                db.Cotizaciones.Add(c);
                db.SaveChanges();
                return c;
            }
        }
        public static void Update(Cotizacion c)
        {
            using (var db = new DBContextProyectosAsfaltos())
            {
                db.Cotizaciones.Update(c);
                db.SaveChanges();
            }
        }
        public static void Delete(Cotizacion c)
        {
            using (var db = new DBContextProyectosAsfaltos())
            {
                db.Cotizaciones.Remove(c);
                db.SaveChanges();
            }
        }


    }
}
