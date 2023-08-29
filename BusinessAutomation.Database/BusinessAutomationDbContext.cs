using BusinessAutomation.Models.EntityModels;
using Microsoft.EntityFrameworkCore;

namespace BusinessAutomation.Database
{
    public class BusinessAutomationDbContext : DbContext
    {
        ////BusinessAutomationDbContext Virtual Database
        ////Table represent korte hole dbset lagbe
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Product> Products { get; set; }  
        public DbSet<Brand> Brands { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
           
            string connectionString = "Server=DESKTOP-D63RLDO;Database=BusinessAutomationDB;User Id=sa;Password=Abjt@8632;";
            optionsBuilder.UseSqlServer(connectionString);
            /*base.OnConfiguring(optionsBuilder);*/
        }

        /*public BusinessAutomationDbContext(DbContextOptions<BusinessAutomationDbContext> options): base(options)
        {

        }*/
         // DbSet for the Customer entity

    }
}
