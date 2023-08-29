using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Modelos
{
    public class Rol
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int RolId { get; set; }
        public string Nombre { get; set; }

        // Relacion

        public ICollection<RolUsuario> RolUsuarios { get; set; }
    }
}
