using CineHome.Api.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace CineHome.Api.Infra.Data.Mapping
{
    public class MovieCategoryMap : IEntityTypeConfiguration<MovieCategoryEntity>
    {
        public void Configure(EntityTypeBuilder<MovieCategoryEntity> builder)
        {
            builder.ToTable("MovieCategory");
            builder.HasKey(p => p.Id);
            builder.Property(p => p.CreateAt).IsRequired();
        }
    }
}
