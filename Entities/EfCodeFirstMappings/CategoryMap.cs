using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.EfCodeFirstMappings
{
    public class CategoryMap : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.HasKey(c => c.CategoryId);
            builder.Property(c => c.Code)
                .HasMaxLength(20);
            builder.Property(c => c.Name)
                .HasMaxLength(120)
                .IsRequired();
            builder.Property(c => c.Image)
                .HasMaxLength(250);
            builder.ToTable("Categories");

        }
    }
}
