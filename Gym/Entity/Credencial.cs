using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Gym.Entity
{
    [Table("Credenciales")]
    public class Credencial
{
        [Key]
        public string Usuario { get; set; }
        public string Contraseña { get; set; }
}
}
