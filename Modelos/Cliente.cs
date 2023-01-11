using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Modelos
{
	public class Cliente
	{
		[Key]
		[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
		public int ClienteId { get; set; }
		public int Cedula { get; set; }
		public string? RazonSocial { get; set; }
		public string? NombreComercial { get; set; }

		// Relaciones
		public ICollection<Proyecto> Proyectos { get; set;}
	}
}
