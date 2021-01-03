using BookStore.Models;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookStore.BookStoreServices
{
  public  interface IBookStoreDbContext
    {
        IMongoCollection<Book> GetCollection();
    }
}
