using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Modelos
{
    public class Proyecto
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]

        // Informacion del proyecto
        public int ProyectoId { get; set; }
        public string Cliente { get; set; }
        public string Cedula { get; set; }
        public bool EsPublico { get; set; }
        public string OfertaId { get; set; }
        public string OrdenCompra { get; set; }
        public DateTime FechaOC { get; set; }
        public string TipoMoneda { get; set; }
        public float Monto { get; set; }
        public float MontoIVA { get; set; }    
        public int PorcentajeAnticipo { get; set; }
        public string Tipo { get; set; }
        public string Descripcion { get; set; }
        public string Provincia { get; set; }
        public string Ubicacion { get; set; }
        public int TareaId { get; set; }
        public Usuario Vendedor { get; set; } 
        public int UsuarioId { get; set; }
        public string Estado { get; set; }
        public bool Finalizado { get; set; }
        // Metadatos
        public string Autor { get; set; }
        public DateTime FechaIngreso { get; set; }
        public DateTime UltimaEdicion { get; set; }
        public string UltimoEditor { get; set; }
        public bool Enable { get; set; }
        public ICollection<Nota> Notas { get; set; }
        public ICollection<Informe> Informes { get; set; }  


    }

}