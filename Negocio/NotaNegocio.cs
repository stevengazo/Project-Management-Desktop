using Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public static class NotaNegocio
    {
        public static List<Nota> GetNotasByProyecto(int proyectoId)
        {
            using (var db = new DBContextProyectosAsfaltos())
            {
                    List<Nota> notas = db.Notas.Where(i=>i.ProyectoId == proyectoId).ToList();  
                return notas;
            }
        }
        public static void Add(Nota nota)
        {
            using (var db = new DBContextProyectosAsfaltos())
            {
                db.Notas.Add(nota);
                db.SaveChanges();
            }
        }
        public static void Edit(Nota nota)
        {
            using (var db = new DBContextProyectosAsfaltos())
            {
                db.Notas.Update(nota);
                db.SaveChanges();
            }
        }
    }
}
