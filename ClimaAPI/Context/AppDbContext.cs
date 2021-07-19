using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ClimaAPI.Models;

namespace ClimaAPI.Context
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options): base (options)
        {

        }

        public DbSet<City> city { get; set; }

        public DbSet<Weather> weather { get; set; }

        public DbSet<Coord> coord { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<City>().HasMany(c => c.weather);

            modelBuilder.Entity<City>().HasOne(c => c.coord).WithOne(co => co.city)
                .HasForeignKey<Coord>(co => co.idCiudad);
        }
    }
}
