using CineHome.Api.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CineHome.Api.Infra.Data.Mapping
{
    public class CategoryMap : IEntityTypeConfiguration<CategoryEntity>
    {
        public void Configure(EntityTypeBuilder<CategoryEntity> builder)
        {
            builder.ToTable("Category");
            builder.HasKey(p => p.Id);
            builder.Property(p => p.CreatedAt).IsRequired();
            builder.HasIndex(p => p.Name).IsUnique();
            builder.Property(p => p.Name);
        }
    }
}
