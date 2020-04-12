using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using BlogDAL.Entities;

namespace BlogDAL
{
    public class MyContext : DbContext 
    {
        public MyContext() : base(@"Data Source=.;Initial Catalog=MyWebBlog;Integrated Security=True")
        {
            Database.SetInitializer<MyContext>(new MigrateDatabaseToLatestVersion<MyContext,  BlogDAL.Migrations.Configuration>());
            Configuration.LazyLoadingEnabled = true;
        }

        
        public DbSet<Article> Articles { get; set; }
        public DbSet<Author> Authors { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Tag> Tags { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Article>()
                .ToTable("Articles")
                .HasKey(x => x.Id);
            modelBuilder.Entity<Article>()
                .Property(x => x.Id)
                .HasColumnName("Id")
                .IsRequired();
            modelBuilder.Entity<Article>()
                .Property(x => x.Title)
                .HasColumnName("Title")
                .IsRequired();
            modelBuilder.Entity<Article>()
                .Property(x => x.Txt)
                .HasColumnName("Txt")
                .IsOptional();
            modelBuilder.Entity<Article>()
                .Property(x => x.Img)
                .HasColumnName("Img")
                .IsOptional();
            modelBuilder.Entity<Article>()
                .Property(x => x.DateArticle)
                .HasColumnName("DataArticle")
                .IsRequired();
            
            modelBuilder.Entity<Author>()
                .ToTable("Authors")
                .HasKey(x => x.Id);
            modelBuilder.Entity<Author>()
                .Property(x => x.Id)
                .HasColumnName("Id")
                .IsRequired();
            modelBuilder.Entity<Author>()
                .Property(x => x.Name)
                .HasColumnName("Name")
                .IsRequired();
            modelBuilder.Entity<Author>()
                .HasMany(x => x.Articles)
                .WithRequired(x => x.Author);

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
            modelBuilder.Entity<Category>()
                .HasMany(x => x.Articles)
                .WithMany(x => x.Categories);

            modelBuilder.Entity<Tag>()
                .ToTable("Tags")
                .HasKey(x => x.Id);
            modelBuilder.Entity<Tag>()
                .Property(x => x.Id)
                .HasColumnName("Id")
                .IsRequired();
            modelBuilder.Entity<Tag>()
                .Property(x => x.Name)
                .HasColumnName("Name")
                .IsRequired();
            modelBuilder.Entity<Tag>()
                .HasMany(x => x.Articles)
                .WithMany(x => x.Tags);

            
        }
    }
}
