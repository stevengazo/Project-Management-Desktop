using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelos
{
    public class Nota
    {
        public int NotaId { get; set; }
        public string Titulo { get; set; }
        public string Descripcion { get; set; }

        public int ProyectoId { get; set; }
        public Proyecto Proyecto { get; set; }

    }
}
