using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Gym.Entity
{
    [Table("Usuarios")]
    public class Usuario
    {
        [Key]
    public int Id { get; set; }
    public string Identificacion { get; set; }
    public string Nombre { get; set; }
    public string Apellido { get; set; }
    public string Direccion { get; set; }
    public string Telefono { get; set; }
    public DateTime FechaNacimiento { get; set; }
    public DateTime FechaInicio { get; set; }
    public DateTime UltimoPago { get; set; }
    public string Eps { get; set; }
}
}
