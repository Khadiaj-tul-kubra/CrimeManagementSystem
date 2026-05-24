using CrimeManagement.UI.Models;
using Microsoft.EntityFrameworkCore;

namespace CrimeManagement.UI.Data
{
    public class AppDbContext : DbContext
    {
        public DbSet<User> Users { get; set; }

        public DbSet<FIR> FIRs { get; set; }

        public DbSet<Criminal> Criminals { get; set; }

        protected override void OnConfiguring(
            DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite(
                "Data Source=crime_management.db");
        }
    }
}