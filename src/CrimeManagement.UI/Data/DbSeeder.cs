using CrimeManagement.UI.Models;

namespace CrimeManagement.UI.Data
{
    public static class DbSeeder
    {
        public static void SeedAdmin()
        {
            using var context = new AppDbContext();

            context.Database.EnsureCreated();

            if (!context.Users.Any())
            {
                context.Users.Add(new User
                {
                    FullName = "Admin",
                    Email = "admin@gmail.com",
                    Password = "123",
                    Role = "Admin"
                });

                context.SaveChanges();
            }
        }
    }
}