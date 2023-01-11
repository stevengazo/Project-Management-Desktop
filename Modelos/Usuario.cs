using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelos
{
	public class Usuario
	{
		[Key]
		[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
		public int UsuarioId { get; set; }
		public string Nombre { get; set; }
		public string HashContraseña { get; set; }

		// Relaciones

		// RolUsuario
		public ICollection<RolUsuario> RolUsuarios { get; set; }


	}
}
