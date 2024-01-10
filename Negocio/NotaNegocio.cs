using Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class NotaNegocio
    {
        public List<Nota> GetNotasByProyecto(int proyectoId)
        {
            using (var db = new DBContextProyectosAsfaltos())
            {
                    List<Nota> notas = db.Notas.Where(i=>i.ProyectoId == proyectoId).ToList();  
                return notas;
            }
        }
        public void Add(Nota nota)
        {
            using (var db = new DBContextProyectosAsfaltos())
            {
                db.Notas.Add(nota);
                db.SaveChanges();
            }
        }
        public void Edit(Nota nota)
        {
            using (var db = new DBContextProyectosAsfaltos())
            {
                db.Notas.Update(nota);
                db.SaveChanges();
            }
        }
    }
}
