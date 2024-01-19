using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelos
{
    public class Informe
    {
        [Key]       
        public int InformeId { get; set; }
        public  string Estado { get; set; }
        public string Descripcion {  get; set; }
        public DateTime FechaRegistro { get; set; }
        public DateTime FechaMaxima { get; set; }
        public string Tecnico { get; set; }
        public int Calificacion { get; set; }
        public string Comentarios { get; set; }
        public bool Concluido { get; set; }
        public string UltimoEditor { get; set; }
        public DateTime UltimaModificacion { get; set; }

        public int ProyectoId { get; set; }
        public Proyecto Proyecto { get; set; }
        
        public int? UsuarioId { get; set; }
        //[ForeignKey(nameof(UsuarioId))]
        public Usuario Usuario { get; set; }
        

    }
}
