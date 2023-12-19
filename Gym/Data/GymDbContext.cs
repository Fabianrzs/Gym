using Gym.Data;
using Gym.Entity;
using System.Data.Entity;
namespace Gym
{
    public class GymDbContext : DbContext
    {
        public GymDbContext() : base("Data Source=(LocalDB)\\MSSQLLocalDB;Initial Catalog=GymDatabase;Integrated Security=True")
        {
            Database.SetInitializer(new GymDbInitializer());
        }

        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Credencial> Credenciales { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        
        }
    }
}
