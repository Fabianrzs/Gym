using System.ComponentModel.DataAnnotations;

namespace Gym.Entity
{
    public class Credencial
{
        [Key]
        public string Usuario { get; set; }
    public string Contraseña { get; set; }
}
}
