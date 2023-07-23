using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;
using Platfrom.Api.DataAccess;
using Platfrom.Api.Models;

namespace Platfrom.Api.DataAccess
{
    public class PlatformContext : DbContext
    {
        private readonly IConfiguration _configurations;

        public PlatformContext(IConfiguration configurations)
        {
            _configurations = configurations;
        }

        public DbSet<Platform> Platforms { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(_configurations.GetConnectionString("platformDb"));
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Platform>().ToTable("PlatformTbl");
            builder.Entity<Platform>().HasKey(p => p.Id);
            builder.Entity<Platform>().Property(p => p.PlatformName).IsRequired().HasColumnType("nvarchar");
            builder
                .Entity<Platform>()
                .Property(p => p.Publisher)
                .IsRequired()
                .HasColumnType("nvarchar");
            builder.Entity<Platform>().Property(p => p.Cost).HasColumnType("nvarchar");
            builder
                .Entity<Platform>()
                .Property(p => p.CreatedAt)
                .ValueGeneratedOnAdd()
                .HasDefaultValue(DateTime.UtcNow);
            builder
                .Entity<Platform>()
                .Property(p => p.ModifiedAt)
                .ValueGeneratedOnAddOrUpdate()
                .HasDefaultValue(DateTime.UtcNow);
        }
    }
}
