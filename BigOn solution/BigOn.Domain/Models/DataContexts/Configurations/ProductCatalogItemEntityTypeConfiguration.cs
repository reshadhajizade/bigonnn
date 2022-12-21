using BigOn.Domain.Models.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BigOn.Domain.Models.DataContexts.Configurations
{
    public class ProductCatalogItemEntityTypeConfiguration
        : IEntityTypeConfiguration<ProductCatalogItem>
    {
        public void Configure(EntityTypeBuilder<ProductCatalogItem> builder)
        {
            builder.HasKey(k => new
            {
                k.ProductSizeId,
                k.ProductTypeId,
                k.ProductId,
                k.ProductMaterialId,
                k.ProductColorId
            });
            builder.Property(t=>t.Id).UseIdentityColumn();
            builder.HasIndex(t => t.Id).IsUnique();
            builder.ToTable("ProductCatalog");
        }
    }
}
