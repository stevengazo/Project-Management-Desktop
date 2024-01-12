using Modelos;

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
        public static string TipoLogin { get; set; }
        /// <summary>
        /// Lista los roles que posee el usuario
        /// </summary>
        public static List<Rol> RolesDeUsuarioActivo { get; set; }

        public static int NotaId { get; set; }

        public static int CotizacioId {  get; set; }

    }
}
