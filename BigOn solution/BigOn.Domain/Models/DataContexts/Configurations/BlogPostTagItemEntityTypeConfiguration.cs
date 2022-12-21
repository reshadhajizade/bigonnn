﻿using BigOn.Domain.Models.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BigOn.Domain.Models.DataContexts.Configurations
{
    public class BlogPostTagItemEntityTypeConfiguration : IEntityTypeConfiguration<BlogPostTagItem>
    {
        public void Configure(EntityTypeBuilder<BlogPostTagItem> builder)
        {
            builder.HasKey(k => new{k.BlogPostId ,k.TagId});
            builder.Property(p=>p.Id)
                .UseIdentityColumn();

            builder.ToTable("BlogPostTagCloud");
        }
    }
}
