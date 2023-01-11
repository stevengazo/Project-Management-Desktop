using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Modelos
{
	
	public class RolUsuario
	{
		[Key]
		[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
		public int RolUsuarioId { get; set; }
		public int RolId { get; set; }
		public Rol Rol { get; set; }
		public int UsuarioId { get; set; }
		public Usuario Usuario { get; set; }	

	}
}
