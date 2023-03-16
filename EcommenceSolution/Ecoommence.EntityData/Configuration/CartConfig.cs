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
    public class CartConfig : IEntityTypeConfiguration<Cart>
    {
        public void Configure(EntityTypeBuilder<Cart> builder)
        {
            builder.ToTable("Cart");
            builder.HasKey(c => c.CartId);

            builder.Property(c => c.CartId).UseIdentityColumn();

            builder.HasOne(c => c.Product).WithMany(c => c.Carts).HasForeignKey(c => c.ProductId);
            
           // throw new NotImplementedException();
        }
    }
}
