using BookStore.DataI.DataContexts;
using BookStore.Domain;
using BookStore.Domain.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity;

namespace BookStore.DataI.Repositories
{
    public class AuthorRepository : IAuthorRepository
    {
        public BookStoreDataContext _db;
        public AuthorRepository()
        {
            _db = new BookStoreDataContext();
        }
        public void Create(Author entity)
        {
           _db.Authors.Add(entity);
           _db.SaveChanges();
        }

        public void Delete(int id)
        {
            _db.Authors.Remove(_db.Authors.Find(id));
            _db.SaveChanges();
        }

        public void Dispose()
        {
            _db.Dispose();
        }

        public List<Author> Get(int skip = 0, int take = 25)
        {
            return _db.Authors.OrderBy(x => x.FirstName).Skip(skip).Take(take).ToList();
        }

        public Author Get(int id)
        {
            return _db.Authors.Find(id);
        }

        public void Update(Author entity)
        {
            _db.Entry<Author>(entity).State = EntityState.Modified;
            _db.SaveChanges();
        }
    }
}
