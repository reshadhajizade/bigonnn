﻿using BigOn.Domain.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace BigOn.Domain.Models.DataContexts
{
    public class BigOnDbContext:DbContext
    {

        public BigOnDbContext(DbContextOptions options)
            : base(options) 
        {

        }
        public DbSet<Category> Categories { get; set; }
        public DbSet<ContactPost> ContactPosts { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<ProductColor> ProductColors { get; set; }
        public DbSet<ProductSize> ProductSizes { get; set; }
        public DbSet<ProductMaterial> ProductMaterials { get; set; }
        public DbSet<Brand> Brands { get; set; }
        public DbSet<ProductType> ProductTypes { get; set; }
        public DbSet<ProductImages> ProductImages { get; set; }
        public DbSet<ProductCatalogItem> ProductCatalog { get; set; }
        public DbSet<Faq> Faqs { get; set; }
        public DbSet<Subscribe> Subscribes { get; set; }

        protected override void OnModelCreating(ModelBuilder ModelBuilder)
        {
            base.OnModelCreating(ModelBuilder);

            ModelBuilder.Entity<ProductCatalogItem>(cfg =>
           {
               cfg.HasKey(k => new
               {
                   k.ProductSizeId,
                   k.ProductTypeId,
                   k.ProductId,
                   k.ProductMaterialId,
                   k.ProductColorId,
                   

               });
               cfg.Property(p =>p.Id).UseIdentityColumn(1, 1);
           });
        }
    }
}
