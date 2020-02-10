using CineHome.Api.Domain.Entities;
using CineHome.Api.Infra.Data.Mapping;
using Microsoft.EntityFrameworkCore;

namespace CineHome.Api.Infra.Data.Context
{
    public class MyContext : DbContext
    {
        public DbSet<MovieEntity> Movies { get; set; }
        public DbSet<CategoryEntity> Categories { get; set; }
        public DbSet<MovieCategoryEntity> MovieCategories { get; set; }

        public MyContext(DbContextOptions<MyContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<MovieEntity>(new MovieMap().Configure);
            modelBuilder.Entity<CategoryEntity>(new CategoryMap().Configure);
            modelBuilder.Entity<MovieCategoryEntity>(new MovieCategoryMap().Configure);
        }
    }
}
