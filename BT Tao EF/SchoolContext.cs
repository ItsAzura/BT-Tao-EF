using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.SqlServer; 
namespace BT_Tao_EF
{
    public class SchoolContext : DbContext
    {
        public DbSet<Student> Student { get; set; }
        public DbSet<Faculty> Facultie { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // Configure your database connection here
            optionsBuilder.UseSqlServer("Data Source=admin;Initial Catalog=EntityDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False");
        }
    }
}
