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
    public class UnitMap : IEntityTypeConfiguration<Unit>
    {
        public void Configure(EntityTypeBuilder<Unit> builder)
        {
            builder.HasKey(u => u.UnitId);
            builder.Property(u => u.Name)
                .HasMaxLength(40)
                .IsRequired();
            builder.Property(u => u.Code)
                .HasMaxLength(20);
            builder.ToTable("Units");

        }
    }
}
