using Gym.Entity;
using System.Data.Entity;

namespace Gym.Data
{
    public class GymDbContext : DbContext
    {
        public GymDbContext() : base("Data Source=(LocalDB)\\MSSQLLocalDB;Initial Catalog=Gym_Database;Integrated Security=True")
        {
        }

        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Credencial> Credenciales { get; set; }
    }
}
