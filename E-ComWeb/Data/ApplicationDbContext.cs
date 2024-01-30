﻿using Microsoft.EntityFrameworkCore;

namespace E_ComWeb.Data
{
    public class ApplicationDbContext : DbContext  
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
            
        }
    }
}
