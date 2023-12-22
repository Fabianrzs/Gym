using Gym.Data;
using Gym.Entity;
using System.Data.Entity.Migrations;

namespace Gym.Migrations
{

    internal sealed class Configuration : DbMigrationsConfiguration<GymDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            AutomaticMigrationDataLossAllowed = true;

        }

        protected override void Seed(GymDbContext context)
        {
            context.Credenciales.AddOrUpdate(
                new Credencial
                {
                    Usuario = "admin",
                    Contraseña = "admin"
                }
            );

            context.SaveChanges();
        }
    }
}
