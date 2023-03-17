using Ecoommence.EntityData.Extentions;
using EshopSolution.Data.Configuration;
using EshopSolution.Data.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EshopSolution.Data.EntityFramwork
{
    public class EshopContext : DbContext
    {
        public EshopContext(DbContextOptions options) : base(options)
        {
        //tạo ra các option use
        }

        // giúp trong việc tạo DB context
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new CartConfig());

            modelBuilder.ApplyConfiguration(new AppConfigguration());

            modelBuilder.ApplyConfiguration(new CategoryConfig());

            modelBuilder.ApplyConfiguration(new CategoryTranslationConfig());

            modelBuilder.ApplyConfiguration(new ProductXCategoryConfig());

            modelBuilder.ApplyConfiguration(new ProductTranslationConfig());

            modelBuilder.ApplyConfiguration(new ProductConfig());

            modelBuilder.ApplyConfiguration(new OrderConfig());

            modelBuilder.ApplyConfiguration(new OrderDetailConfig());

         //   modelBuilder.ApplyConfiguration(new ProductImage());

            modelBuilder.ApplyConfiguration(new LanguageConfig());

            modelBuilder.ApplyConfiguration(new PromotionConfig());

            modelBuilder.ApplyConfiguration(new TransactionConfig());

            modelBuilder.ApplyConfiguration(new ContactConfig());

            //  base.OnModelCreating(modelBuilder);


            //Data seeding
          modelBuilder.Seed();
        }

        public DbSet<Product> Products { get; set; }

        public DbSet<Category> Categories { get; set; }

        public DbSet<AppConfig> AppConfigs { get; set; }

        public DbSet<Cart> Carts { get; set; }

        public DbSet<CategoryTranslation> CategoryTranslations { get; set; }

        public DbSet<ProductXCategory> productXCategories { get; set; }

        public DbSet<Contact> Contacts { get; set; }

        public DbSet<Language> Languages { get; set; }

        public DbSet<Order> Orders { get; set; }

        public DbSet<OrderDetail> OrderDetails { get; set; }

        public DbSet<ProductTranslation> ProductTranslations { get; set; }

        public DbSet<Promotion> Promotions { get; set; }


        public DbSet<Transaction> Transactions { get; set; }
    }
}
