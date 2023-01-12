using Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaz
{
	public static class Temporal
	{
		/// <summary>
		/// Trae la Información del Usuario Activo
		/// </summary>
		public static Usuario UsuarioActivo { get; set; }
		/// <summary>
		/// Indica el tipo de Usuario 
		/// </summary>
		public static string TipoUsuario { get; set; }
		/// <summary>
		/// Lista los roles que posee el usuario
		/// </summary>
		public static List<Rol> RolesDeUsuarioActivo { get; set; }

	}
}
