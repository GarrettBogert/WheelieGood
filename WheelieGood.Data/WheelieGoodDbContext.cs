using Microsoft.EntityFrameworkCore;
using WheelieGood.Core;

namespace WheelieGood.Data
{
    public class WheelieGoodDbContext : DbContext
    {
        public WheelieGoodDbContext(DbContextOptions<WheelieGoodDbContext> options) : base(options)
        {

        }
        public DbSet<Bike> Bikes { get; set; }
        public DbSet<WebImage> Images { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Article> Articles { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<WebImage>()
                .HasKey(o => o.Id);
           
        }
    }
}
