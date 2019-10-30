using BookStore.Domain;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Text;

namespace BookStore.DataI.DataContexts.Mappings
{
    public class AuthorMap : EntityTypeConfiguration<Author>
    {
        public AuthorMap()
        {
            ToTable("author");

            HasKey(x => x.Id);
            Property(x => x.FirstName).HasMaxLength(60).IsRequired();
            Property(x => x.LastName).HasMaxLength(60).IsRequired();
        }
    }
}
