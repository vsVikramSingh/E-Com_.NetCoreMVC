using E_ComWeb.Models;
using ECom.Models;
using Microsoft.EntityFrameworkCore;

namespace E_ComWeb.Data
{
    public class ApplicationDbContext : DbContext  
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
            
        }

        // create table
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }

    }
}
