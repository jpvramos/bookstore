﻿using System;
using System.Collections.Generic;
using System.Text;

namespace BookStore.Domain.Contracts
{
    public interface IBookRepository : IRepository<Book>
    {
        List<Book> GetWithAuthors(int skip = 0, int take = 25);
        Book GetWithAuthors(int id);
    }
}
