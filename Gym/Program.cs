using Gym.Data;
using Gym.Site;
using System.Data.Entity.Migrations;

namespace Gym
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            Application.Run(new Login());
        }
    }
}