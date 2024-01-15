using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelos
{
    public class Informe
    {
        public int InformeId { get; set; }
        public  string Estado { get; set; }
        public DateTime FechaRegistro { get; set; }
        public DateTime FechaMaxima { get; set; }
        public string Autor {  get; set; }
        public string Tecnico { get; set; }
        public int Calificacion { get; set; }
        public string Comentarios { get; set; }
        public string UltimoEditor { get; set; }
        public DateTime UltimaModificacion { get; set; }

        public int ProyectoId { get; set; }
        public Proyecto Proyecto { get; set; }

        public int UsuarioId { get; set; }
        public Usuario Usuario { get; set; }


    }
}
