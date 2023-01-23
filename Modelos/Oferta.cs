using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelos
{
	public class Oferta
	{
		[Key]
		[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
		public int OfertaId { get; set; }
		public DateTime Fecha { get; set; }
		public int Codigo { get; set; }
		public bool Sellador { get; set; }
		public bool Asfalto { get; set; }
		public bool Base { get; set; }
		public bool SubBase { get; set; }
		public bool Excavacion { get; set; }
		public float Monto { get; set; }
		public string Notas { get; set; }
		public string Observaciones { get; set; }
		public string AutorPrespuesto { get; set; }
		public string Cliente { get; set; }	

		public DateTime UltimaModificacion { get; set; }

		// Relacion
		public Usuario Encargado { get; set; }
		public int UsuarioId { get; set; }


	}
}
