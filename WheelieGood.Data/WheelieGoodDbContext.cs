using Microsoft.EntityFrameworkCore;
using WheelieGood.Core;
using WheelieGood.Core;
using System;
using System.Collections.Generic;
using System.Text;

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
        //private static BikeManufacturer[] getStaticManufacturers()
        //{

        //    var manufacturers = new List<BikeManufacturer>();
       
        //        manufacturers.Add(new BikeManufacturer { Id = 0, Name = "Honda" }      );
        //        manufacturers.Add(new BikeManufacturer { Id = 1, Name = "Yamaha" }     );
        //        manufacturers.Add(new BikeManufacturer { Id = 2, Name = "Suzuki" }     );
        //        manufacturers.Add(new BikeManufacturer { Id = 3, Name = "Beta" }       );
        //        manufacturers.Add(new BikeManufacturer { Id = 4, Name = "Husqvarna" }  );
        //        manufacturers.Add(new BikeManufacturer { Id = 5, Name = "KTM" }        );
        //        manufacturers.Add(new BikeManufacturer { Id = 6, Name = "Indian" }     );
        //    return manufacturers.ToArray();
        //}
    }
}
