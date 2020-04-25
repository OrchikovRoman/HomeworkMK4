using ModuleDAL.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static ModuleDAL.Migrations.Configuration;

namespace ModuleDAL
{
    public class MyContext : DbContext
    {
        public MyContext() : base(@"Data Source=.;Initial Catalog=Module;Integrated Security=True")
        {
            Database.SetInitializer<MyContext>(new MyContextInitializer());
        }

        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }

        

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>()
                .ToTable("Products")
                .HasKey(x => x.Id);
            modelBuilder.Entity<Product>()
                .Property(x => x.Id)
                .HasColumnName("Id")
                .IsRequired();
            modelBuilder.Entity<Product>()
                .Property(x => x.Name)
                .HasColumnName("Name")
                .IsRequired();
            modelBuilder.Entity<Product>()
                .Property(x => x.Price)
                .HasColumnName("Price")
                .IsOptional();
            modelBuilder.Entity<Product>()
                .Property(x => x.CategoryId)
                .HasColumnName("CategoryId")
                .IsRequired();
            
            modelBuilder.Entity<Category>()
                .ToTable("Categories")
                .HasKey(x => x.Id);
            modelBuilder.Entity<Category>()
                .Property(x => x.Id)
                .HasColumnName("Id")
                .IsRequired();
            modelBuilder.Entity<Category>()
                .Property(x => x.Name)
                .HasColumnName("Name")
                .IsRequired();
           

        }
    }
}
