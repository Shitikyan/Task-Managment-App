using Microsoft.EntityFrameworkCore;
using TaskTimeManager.Models;

namespace TaskTimeManager
{
    public class TaskContext : DbContext
    {
        public DbSet<Models.Task> Tasks { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // Replace with your connection string
            string connectionString = "Server=localhost;Database=master;Integrated Security=True;TrustServerCertificate=True;";
            optionsBuilder.UseSqlServer(connectionString);
        }
    }
}
