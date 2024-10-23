using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace CoreAndFoodFix.Data.Models
{
    public class Context : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=DESKTOP-LLPCPH2\\SQLEXPRESS; database=DbCoreFoodFix; integrated security=true ");
        }

        public DbSet<Food> Foods { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Admin> Admins { get; set; }

    }
}
