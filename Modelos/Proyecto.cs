using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Modelos
{
	public class Proyecto
	{
		[Key]
		[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
		public int ProyectoId { get; set; }
		public DateTime FechaOC { get; set; }
		public string Contacto { get; set; }
		public string OfertaId { get; set; }
		public float Monto { get; set; }
		public int PorcentajeAnticipo { get; set; }
		public string FacturaAnticipoId { get; set; }
		public string FacturaFinalId { get; set; }
		public int TareaId { get; set; }
		public string Ubicacion { get; set; }
		public DateTime FechaInicio { get; set; }
		public DateTime FechaFinal { get; set; }
		public string Estado { get; set; }

		public string Autor { get; set; }
		public DateTime UltimaEdicion { get; set; }



		// Relaciones

		/// Vendedor
		public int VendedorId { get; set; }
		public Vendedor Vendedor { get; set; }

		// Cliente
		public int ClienteId { get; set; }
		public Cliente Cliente { get; set; }
	}
}