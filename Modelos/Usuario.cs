using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Modelos
{
    public class Usuario
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int UsuarioId { get; set; }
        public string Nombre { get; set; }
        public string Login { get; set; }
        public bool Activo { get; set; }
        public string HashContraseña { get; set; }

        // Relaciones

        // RolUsuario
        public ICollection<RolUsuario> RolUsuarios { get; set; }
        public ICollection<Oferta> Ofertas { get; set; }
        public ICollection<Proyecto> Proyectos { get; set; }

    }
}
