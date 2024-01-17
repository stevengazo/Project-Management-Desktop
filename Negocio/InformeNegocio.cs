using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Modelos;

namespace Negocio
{
    public class InformeNegocio
    {
        public static List<Informe> ListUnfinished()
        {
            using (var db = new DBContextProyectosAsfaltos())
            {
                return db.Informes
                     .Where(i => !i.Concluido)
                     .OrderByDescending(i => i.InformeId)
                     .Include(i=> i.Proyecto)
                     .Include(i=>i.Usuario)
                     .ToList();
            }
        }
        public static List<Informe> ListFinished(int year = 0)
        {
            using (var db = new DBContextProyectosAsfaltos())
            {
                return db.Informes
                     .Where(i => i.Concluido && i.FechaRegistro.Year == year)
                     .OrderByDescending(i => i.InformeId)
                     .Include(i => i.Proyecto)
                     .Include(i => i.Usuario)
                     .ToList();
            }
        }



        public static List<Informe> GetList( int year= 0)
        {
            using (var db = new DBContextProyectosAsfaltos())
            {
               return db.Informes
                    .Where(i=>i.FechaRegistro.Year  == year  || !i.Concluido)
                    .OrderByDescending(i=>i.InformeId)
                    .Include(i=>i.Proyecto)
                    .Include(i=>i.Usuario)
                    .ToList(); 

            }
        }

        public static int LastNumber()
        {
            using (var db = new DBContextProyectosAsfaltos())
            {
                return db.Informes.LastOrDefault().ProyectoId;
            }

        }
        public static void Add(Informe informe)
        {
            try
            {

                using (var db = new DBContextProyectosAsfaltos())
                {
                    db.Informes.Add(informe);
                    db.SaveChanges();
                }
            }
            catch (Exception f)
            {

                throw f;
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
