using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelos
{
	public class Vendedor
	{
		[Key]
		[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
		public int VendedorId { get; set; }
		public string Nombre { get; set; }	

		// Relacion

		public ICollection<Proyecto> Proyectos { get; set;}
	}
}
