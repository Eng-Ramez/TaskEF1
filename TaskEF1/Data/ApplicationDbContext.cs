using Microsoft.EntityFrameworkCore;
using TaskEF1.Models;


namespace TaskEF1.Data
{
    internal class ApplicationDbContext : DbContext
    {
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
           

            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer("Server =.; Database=EF12_;Trusted_connection=True;TrustServerCertificate=True");
            /*
             Serever = . Or Localhost
             Datebase == Create DataBase in SQLServer 
             Trusted_connection => If You Want a UserName and PassWord
             TrustServerCertificate=>SSL 
             */

        }

    }
}
