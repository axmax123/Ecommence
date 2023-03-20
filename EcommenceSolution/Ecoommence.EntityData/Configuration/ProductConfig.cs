﻿using EshopSolution.Data.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EshopSolution.Data.Configuration
{
    public class ProductConfig : IEntityTypeConfiguration<Product>

    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {

            builder.ToTable("Product");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Price).IsRequired();

            builder.Property(x => x.OriginalPrice).IsRequired();

            builder.Property(x => x.Stock).IsRequired().HasDefaultValue(0); 

            builder.Property(x => x.ViewCount).IsRequired().HasDefaultValue(0);


            //throw new NotImplementedException();
        }
    }
}
