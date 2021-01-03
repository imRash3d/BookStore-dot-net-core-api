using BookStore.Models;
using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookStore.BookStoreServices
{
    public interface IBookService
    {

        List<Book> GetBooks();

        Book GetBook(string id);
        Book CreateBook (Book book);
        bool EditBook(Book book);

        bool DeleteBook(string id);
    }
}
