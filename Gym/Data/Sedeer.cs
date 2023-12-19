using Gym.Entity;
using System.Data.Entity;
namespace Gym.Data
{
    public class GymDbInitializer : DropCreateDatabaseIfModelChanges<GymDbContext>
{
    protected override void Seed(GymDbContext context)
    {
        if (!context.Credenciales.Any())
        {
            var credencial = new Credencial
            {
                Usuario = "admin",
                Contraseña = "admin"
            };

            context.Credenciales.Add(credencial);
            context.SaveChanges();
        }
    }
}
}