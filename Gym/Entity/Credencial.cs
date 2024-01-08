using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;

namespace Gym.Entity
{
    [Table("Credenciales")]
    public class Credencial
{
        [Key]
        public string NombreUsuario { get; set; }
        public string Contraseña { get; set; }
        public string Rol { get; set; } = "Usuario";

    }
}
