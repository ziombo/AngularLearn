using Microsoft.EntityFrameworkCore;
using Vega.Models;

namespace Vega.Persistence
{
    public class VegaDbContext : DbContext
    {
        public DbSet<Make> Makes { get; set; }
        public DbSet<Feature> Features { get; set; }
        public DbSet<Vehicle> Vehicles {get;set;}

        public VegaDbContext(DbContextOptions<VegaDbContext> option)
        : base(option)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<VehicleFeatures>().HasKey(vf => 
                new { vf.VehicleId, vf.FeatureId});
        }
    }
}