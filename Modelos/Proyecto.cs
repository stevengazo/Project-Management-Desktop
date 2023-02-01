using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Modelos
{
	public class Proyecto
	{
		[Key]
		[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
		public int ProyectoId { get; set; }
		public DateTime FechaOC { get; set; }
		public string Contacto { get; set; }
		public string Cliente { get; set; }
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
		public string UltimoEditor { get; set; }
		public Usuario Vendedor { get; set; }
		public int UsuarioId { get; set; }
		public bool Enable { get; set; }

		//public int ClienteID { get; set; }
		//public Cliente Cliente { get; set;}


	}

}