using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Modelos
{
    public class Oferta
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int OfertaId { get; set; }
        public DateTime Fecha { get; set; }
        public int Codigo { get; set; }
        public float Monto { get; set; }
        public bool DDCE { get; set; }
        public bool Ionizante { get; set; }
        public bool Supresor { get; set; }
        public bool Torre { get; set; }
        public bool Malla { get; set; }
        public bool Otros { get; set; }
        public string Categoria { get; set; }
        public string Notas { get; set; }
        public string Provincia { get; set; }
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
