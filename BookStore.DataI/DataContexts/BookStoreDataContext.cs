using System;
using System.Collections.Generic;
using System.Text;
using System.Data.Entity;
using BookStore.Domain;
using BookStore.DataI.DataContexts.Mappings;

namespace BookStore.DataI.DataContexts
{
    public class BookStoreDataContext : DbContext 
    {
        public BookStoreDataContext()
            :base("BookStoreConnectionString")
        {
            Configuration.LazyLoadingEnabled = false;
            Configuration.ProxyCreationEnabled = false;

        }

        public DbSet<Book> Books { get; set; }
        public DbSet<Author> Authors { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new BookMap());
            modelBuilder.Configurations.Add(new AuthorMap());
            base.OnModelCreating(modelBuilder);
        }

    }
}
