using EshopSolution.Data.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EshopSolution.Data.Configuration
{
    public class ProductXCategoryConfig : IEntityTypeConfiguration<ProductXCategory>
    {
        public void Configure(EntityTypeBuilder<ProductXCategory> builder)
        {

            builder.HasKey(t => new { t.ProductId, t.CategoryId });
            builder.ToTable("ProductXCategory");


            // relationship Product x Category
            builder.HasOne(t => t.Product).WithMany(pc => pc.ProductXCategories).HasForeignKey(pc => pc.ProductId);
            builder.HasOne(t => t.Category).WithMany(pc => pc.ProductXCategories).HasForeignKey(pc => pc.CategoryId);
            //throw new NotImplementedException();
        }
    }
}
