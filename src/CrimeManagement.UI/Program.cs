using CrimeManagement.UI.Forms;
using CrimeManagement.UI.Data;
namespace CrimeManagement.UI
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
           
            ApplicationConfiguration.Initialize();
            DbSeeder.SeedAdmin();
            Application.Run(new LoginForm());
        }
    }
}