using BookStore.Models;
using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookStore.BookStoreServices
{
    public class BookService : IBookService

    {

        private readonly IMongoCollection<Book> _books;


        public BookService(IBookStoreDbContext bookStoreDb)
        {
            _books = bookStoreDb.GetCollection();
        }

        public Book CreateBook(Book book)
        {
            _books.InsertOne(book);
            return book;
        }

        public bool DeleteBook(string id)
        {
            var foundBook = GetBook(id);
            if (foundBook != null)
            {
                _books.DeleteOne(b => b.Id == id);
                return true;
            }
            return false;
           
        }

        public bool EditBook(Book book)
        {
             _books.ReplaceOne(b => b.Id == book.Id, book);
            return true;

        }

        public Book GetBook(string id)
        {
          return  _books.Find(b => b.Id == id).First();
        }

        public List<Book> GetBooks()
        {
            return _books.Find<Book>(b => true).ToList();
        }

    }
}
