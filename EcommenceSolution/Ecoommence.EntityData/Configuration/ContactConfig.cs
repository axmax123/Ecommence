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
    public class ContactConfig : IEntityTypeConfiguration<Contact>
    {
        public void Configure(EntityTypeBuilder<Contact> builder)
        {
            builder.ToTable("Contact");
            builder.HasKey(c => c.ContactId);

            builder.Property(c => c.ContactId).UseIdentityColumn();
            builder.Property(c => c.Name).HasMaxLength(200).IsRequired();

            builder.Property(c => c.Email).HasMaxLength(200).IsRequired();
            builder.Property(c => c.PhoneNumber).HasMaxLength(200).IsRequired();
            builder.Property(c => c.Message).IsRequired();

            // throw new NotImplementedException();
        }
    }
}
