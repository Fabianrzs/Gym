using Gym.Data;
using System.Data.Entity.Migrations;

namespace Gym
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {

            var configuration = new DbMigrationsConfiguration<GymDbContext>
            {
                AutomaticMigrationsEnabled = true,
                AutomaticMigrationDataLossAllowed = true 
            };

            var migrator = new DbMigrator(configuration);
            migrator.Update(); 

            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new Login());
        }
    }
}