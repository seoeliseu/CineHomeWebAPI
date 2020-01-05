using CineHome.Api.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CineHome.Api.Infra.Data.Mapping
{
    public class MovieMap : IEntityTypeConfiguration<MovieEntity>
    {
        public void Configure(EntityTypeBuilder<MovieEntity> builder)
        {
            builder.ToTable("Movie");
            builder.HasKey(p => p.Id);
            builder.Property(p => p.CreateAt).IsRequired();
            builder.Property(p => p.OriginalTitle).IsRequired().HasMaxLength(255);
            builder.Property(p => p.NationalTitle).HasMaxLength(255);
            builder.Property(p => p.DurationMinutes);
            builder.Property(p => p.ReleaseYear).HasMaxLength(32767);
        }
    }
}
