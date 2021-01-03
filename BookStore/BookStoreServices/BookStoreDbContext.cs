using BookStore.Models;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookStore.BookStoreServices
{
    public class BookStoreDbContext : IBookStoreDbContext
    {
        private readonly IMongoCollection<Book> _books;

       public BookStoreDbContext(IMongoClient client)
        {
            var database = client.GetDatabase("BooKStoreDb");
            _books = database.GetCollection<Book>("books");

        }
        public IMongoCollection<Book> GetCollection()
        {
            return _books;
        }
    }
}
