using Microsoft.EntityFrameworkCore;
using NZWalksAPI.Models.Domain;

namespace NZWalksAPI.Data
{
    public class NZWalksDbContext : DbContext
    {
        public NZWalksDbContext(DbContextOptions dbContextOptions) : base(dbContextOptions)
        {

        }

        public DbSet<Difficulty> Difficulties { get; set; }

        public DbSet<Region> Regions { get; set; }

        public DbSet<Walk> Walks { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Seed data for Difficulties
            // Easy, Medium, Hard

            var difficulties = new List<Difficulty>()
            {
                new Difficulty()
                {
                    Id = Guid.Parse("e80644be-ff45-4735-a7db-a9d42bb0974c"),
                    Name = "Easy"
                },

                new Difficulty()
                {
                    Id = Guid.Parse("f3c86ae4-e7af-4a81-85f8-6b8fc9437e4b"),
                    Name = "Medium"
                },

                new Difficulty()
                {
                    Id = Guid.Parse("1f34fc24-2aef-4806-8d29-7d3d2725b1a1"),
                    Name = "Hard"
                }
            };

            // Seed difficulties to the database
            modelBuilder.Entity<Difficulty>().HasData(difficulties);

            // Seed data for Regions
            var regions = new List<Region>
            {
                new Region
                {
                    Id = Guid.Parse("5ffa4e22-d1c0-470b-8a9c-8f04b27d3093"),
                    Code = "AKL",
                    Name = "Auckland",
                    RegionImageUrl = "https://example.com/images/auckland.jpg"
                },
                new Region
                {
                    Id = Guid.Parse("453733fc-3190-4b41-88fe-17fba54de503"),
                    Code = "N",
                    Name = "NN",
                    RegionImageUrl = "https://example.com/images/auckland.jpg"
                },
                new Region
                {
                    Id = Guid.Parse("c20f936e-5de1-434c-a2be-97ad2fd03867"),
                    Code = "Ne",
                    Name = "NNee",
                    RegionImageUrl = "https://example.com/images/auckland.jpg"
                },
                new Region
                {
                    Id = Guid.Parse("05842e4d-59b0-4fb1-8ac7-cf5018f60d39"),
                    Code = "New",
                    Name = "NNeeww",
                    RegionImageUrl = "https://example.com/images/auckland.jpg"
                }
            };

            modelBuilder.Entity<Region>().HasData(regions);
        }
    }
}
