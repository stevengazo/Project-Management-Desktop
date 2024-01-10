using System.ComponentModel.DataAnnotations;

namespace Modelos
{
    public class Oferta
    {
        [Key]
        public int OfertaId { get; set; }
        public DateTime Fecha { get; set; }
        public int Codigo { get; set; }
        public float Monto { get; set; }
        public string Notas { get; set; }
        public string Observaciones { get; set; }
        public string EncargadoCotizador { get; set; }
        public string AutorPrespuesto { get; set; }
        public string Cliente { get; set; }

        public DateTime UltimaModificacion { get; set; }

        // Relacion
        public Usuario Encargado { get; set; }
        public int UsuarioId { get; set; }


    }
}
