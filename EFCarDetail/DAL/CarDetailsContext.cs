﻿//using DAL.Migrations;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class CarDetailsContext : DbContext
    {
        public CarDetailsContext() : base(@"Data Source=.;Initial Catalog=Automobile;Integrated Security=True")
        {
            //Database.SetInitializer(new MigrateDatabaseToLatestVersion<CarDetailsContext, Configuration>());
            Configuration.LazyLoadingEnabled = true;
        }

        public DbSet<Car> Car { get; set; }
        public DbSet<Detail> Detail { get; set; }
        public DbSet<DetailType> DetailTypes { get; set; }
        public DbSet<Manufacturer> Manufacturers { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Car>()
                .ToTable("Car")
                .HasKey(x=>x.Id);
            
            modelBuilder.Entity<Car>()
                .Property(x => x.Id)
                .HasColumnName("Id")
                .IsRequired();
            modelBuilder.Entity<Car>()
                .Property(x => x.Name)
                .HasColumnName("Name")
                .IsRequired();
            modelBuilder.Entity<Car>()
                .HasMany(x => x.Details)
                .WithRequired(x=>x.Car)
                .HasForeignKey(x=>x.CarID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Detail>()
                .ToTable("Detail")
                .HasKey(x => x.Id);

            modelBuilder.Entity<Detail>()
                .Property(x => x.Id)
                .HasColumnName("Id")
                .IsRequired();
            modelBuilder.Entity<Detail>()
                .Property(x => x.Name)
                .HasColumnName("Name")
                .IsRequired();
            modelBuilder.Entity<Detail>()
                .Property(x => x.CarID)
                .HasColumnName("CarID")
                .IsRequired();
            modelBuilder.Entity<Detail>()
                .Property(x => x.Price)
                .HasColumnName("Price")
                .IsRequired();

            modelBuilder.Entity<DetailType>()
                .ToTable("DetailTypes")
                .HasKey(x => x.Id);

            modelBuilder.Entity<DetailType>()
                .Property(x => x.Id)
                .HasColumnName("Id")
                .IsRequired();
            modelBuilder.Entity<DetailType>()
                .Property(x => x.Name)
                .HasColumnName("Name")
                .IsOptional();
            modelBuilder.Entity<DetailType>()
                .HasMany(x => x.Details)
                .WithRequired(x => x.DetailType)
                .HasForeignKey(x => x.DetailTypeId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Manufacturer>()
                .ToTable("Manufacturer")
                .HasKey(x => x.Id)
                .Property(x => x.Name)
                .HasMaxLength(20);

            modelBuilder.Entity<Manufacturer>()
                .HasMany(x => x.Cars)
                .WithRequired(x => x.Manufacturer)
                .HasForeignKey(x => x.ManufacturerId)
                .WillCascadeOnDelete(false);
            modelBuilder.Entity<Manufacturer>()
                .HasMany(x => x.Details)
                .WithRequired(x => x.Manufacturer)
                .HasForeignKey(x => x.ManufacturerId)
                .WillCascadeOnDelete(false);

        }
    }
}
