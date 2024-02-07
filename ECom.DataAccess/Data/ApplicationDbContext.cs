using E_ComWeb.Models;
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
    }
}
