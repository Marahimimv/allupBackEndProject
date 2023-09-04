using allupBackEndProject.Models;
using Microsoft.EntityFrameworkCore;

namespace allupBackEndProject.DataAccessLayer
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
        public DbSet<Setting> Settings{ get; set; } 
        public DbSet<Category> Categories { get; set; }
    }
}
