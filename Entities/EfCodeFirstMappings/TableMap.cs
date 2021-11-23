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
    public class TableMap : IEntityTypeConfiguration<Table>
    {
        public void Configure(EntityTypeBuilder<Table> builder)
        { 
            builder.Property(t => t.TableId)
                .HasDefaultValue(Guid.NewGuid());

            builder.Property(t => t.TableId)
                .IsRequired().ValueGeneratedOnAdd();
            builder.Property(t => t.TableName)
                .HasMaxLength(40)
                .IsRequired();
            builder.Property(t => t.TableStatus)
                .IsRequired();
            builder.ToTable("Tables");
        }
    }
}
