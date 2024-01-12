using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelos
{
    public class Cotizacion
    {
        [Key]
        public int CotizacionId { get; set; }
        public string Cliente { get; set; }
        public string Titulo { get; set; }
        public string Categoria { get; set; }   
        public string Descripcion { get; set; }
        public string Provincia { get; set; }
        public string Canton {  get; set; }
        public int Trabajadores { get; set; }
        public float DiasLaborales { get; set; }
        public float MontoMO { get; set; }
        public float MontoKM { get; set; }
        public float MontoMaterial { get; set; }
        public float MontoProductos { get; set; }
        public float MontoViaticos { get; set; }    
        public float Imprevisto {  get; set; }
        public string Autor { get; set; }
        public bool EsPublico { get; set; } 
        public float Total { get; set; }
        public DateTime Creación { get; set; }
        public string RutaArchivo { get; set; }    
        public string UltimoEditor { get; set; }
        public DateTime UltimaModificacion { get; set; }
        public Oferta Oferta { get; set; }
        public int OfertaId { get; set; }

    }
}
