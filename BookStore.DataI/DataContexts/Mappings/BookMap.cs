using BookStore.Domain;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Text;

namespace BookStore.DataI.DataContexts.Mappings
{
    public class BookMap : EntityTypeConfiguration<Book> 
    {
        public BookMap()
        {
            ToTable("book");

            HasKey(x => x.Id);
            Property(x => x.Title).HasMaxLength(255).IsRequired();
            Property(x => x.Price).IsRequired().HasColumnType("Money");
            Property(x => x.ReleaseDate).IsRequired();
            HasMany(x => x.Authors).WithMany(x => x.Books);
        }

    }
}
