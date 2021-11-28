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
    public class ProductMap : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.Property(p => p.ProductId)
                .ValueGeneratedOnAdd()
                .IsRequired();
            builder.HasKey(p => p.ProductId);
            builder.Property(p => p.Name)
                .HasMaxLength(120)
                .IsRequired();
            builder.Property(p => p.Code)
                .IsRequired()
                .HasMaxLength(20);
            builder.Property(p => p.UnitId)
                .IsRequired();
            builder.Property(p => p.CostPrice)
                .IsRequired();
            builder.Property(p => p.Price)
                .IsRequired();
            builder.Property(p => p.Image)
                .HasMaxLength(256);
            builder.Property(p => p.CategoryId)
                .HasMaxLength(10);
            builder.Property(p => p.SubCategoryId)
                .HasMaxLength(10);
            builder.Property(p => p.Quantity)
                .HasMaxLength(20);
            builder.Property(p => p.AletQuantity)
                .HasMaxLength(10);

            builder.ToTable("Products");


            /* Bire Çok İlişki
            builder.HasOne(p => p.Unit)
                .WithMany(p => p.Products)
                .HasForeignKey(p => p.UnitId);*/


        }
    }
}
