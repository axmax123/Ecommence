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
    public class OrderDetailConfig : IEntityTypeConfiguration<OrderDetail>
    {
        public void Configure(EntityTypeBuilder<OrderDetail> builder)
        {

            builder.ToTable("OrderDetails");
            //khoá 
            builder.HasKey(od => new {od.ProductId, od.OrderId });

            // relationship 1-1
            builder.HasOne(od => od.Order).WithMany(od => od.Details).HasForeignKey(od => od.OrderId);

            builder.HasOne(od => od.Product).WithMany(od => od.OrderDetails).HasForeignKey(od => od.ProductId);
           // throw new NotImplementedException();
        }
    }
}
