using BookStore.BookStoreServices;
using BookStore.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookStore.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class BooksController : ControllerBase
    {

        private readonly IBookService _books;

        public BooksController(IBookService bookservices)
        {
            _books = bookservices;

        }

        [HttpGet]
     
        public IActionResult GetBooks()
        {
            return Ok(_books.GetBooks());
        }

        [HttpPost]
    
        public IActionResult CreateBook(Book book)
        {
            var result = _books.CreateBook(book);
            if(result != null)
            {
                return Ok(result); 

            }

            return NotFound("No book added");

        }



        [HttpGet("{id}",Name = "Getbook")]

        public IActionResult Getbook(string id)
        {
            var result = _books.GetBook(id);
            if (result != null)
            {
                return Ok(result);

            }

            return NotFound("No book Found");
        }




        [HttpPut]

        public IActionResult EditBook(Book book)
        {
            var result = _books.EditBook(book);
            if (result)
            {
                return Ok("Book updated successfully");

            }

            return NotFound("Failed to updated book ");
        }


        [HttpDelete("{id}", Name = "DeleteBook")]

        public IActionResult DeleteBook(string id)
        {
            var result = _books.DeleteBook(id);
            if (result)
            {
                return Ok("Book deleted successfully");

            }

            return NotFound("No book Found");
        }

    }
}
