using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelos;

namespace Negocio
{
    public class InformeNegocio
    {

        public static List<Informe> GetList( int year= 0)
        {
            using (var db = new DBContextProyectosAsfaltos())
            {
               return db.Informes
                    .Where(i=>i.FechaRegistro.Year  == year)
                    .OrderByDescending(i=>i.InformeId)
                    .ToList(); 

            }
        }
        public static void Add(Informe informe)
        {
            using (var db = new DBContextProyectosAsfaltos())
            {
                db.Informes.Add(informe);
                db.SaveChanges();
            }
        }

        public static void Update(Informe informe)
        {
            using (var db = new DBContextProyectosAsfaltos())
            {
                db.Informes.Update(informe);
                db.SaveChanges();
            }
        }

        public static void Remove(Informe informe)
        {
            using (var db = new DBContextProyectosAsfaltos())
            {
                db.Informes.Remove(informe);
                db.SaveChanges();
            }
        }

        public static Informe GetById(int id = 0)
        {
            using (var db = new DBContextProyectosAsfaltos())
            {
                return db.Informes.FirstOrDefault(i=>i.InformeId == id);
            }
        }

    }
}
