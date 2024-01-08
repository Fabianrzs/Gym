using Gym.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Data.Entity;
namespace Gym.Data
{
    public class GymDbInitializer
    {
        public GymDbInitializer()
        {
        }

        public void Configure(EntityTypeBuilder<Credencial> builder)
        {
            builder.HasData(
                new Credencial
                {
                    NombreUsuario = "admin",
                    Contraseña = "admin",
                    Rol = "admin"
                }
            );
        }
    }
}