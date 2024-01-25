using Gym.Entity;
using System.Data.Entity;

namespace Gym.Data
{
    public class GymDbContext : DbContext
    {
        public GymDbContext() : base("Data Source=(LocalDB)\\MSSQLLocalDB;Initial Catalog=Gym1_Database;Integrated Security=True")
        {
            Usuarios = Set<Usuario>();
            Credenciales = Set<Credencial>();
        }

        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Credencial> Credenciales { get; set; }
    }
}
