using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using BlogDAL.Models;

namespace BlogDAL
{
    public class MyContext<T> : DbContext where T:class
    {
        public MyContext() : base(@"Data Source=.\SQLEXPRESS;Initial Catalog=WebDB;Integrated Security=True")
        {

        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Author>()
                .HasMany(x => x.Articles)
                .WithRequired(x => x.Author);
        }

        public DbSet<T> Get { get; set; }
    }
}
