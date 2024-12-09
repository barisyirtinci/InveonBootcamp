using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using EndpointNaming.Models;

namespace EndpointNaming.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class BooksController : ControllerBase
    {
        private static List<Book> books = new List<Book>
        {
            new Book { Id = 1, Title = "1984", Genre = "Dystopian", AuthorId = 1 },
            new Book { Id = 2, Title = "Brave New World", Genre = "Science Fiction", AuthorId = 2 }
        };

        // GET: api/books
        [HttpGet]
        public IActionResult GetAllBooks()
        {
            return Ok(books);
        }

        // GET: api/books/1
        [HttpGet("{id}")]
        public IActionResult GetBookById(int id)
        {
            var book = books.FirstOrDefault(b => b.Id == id);
            if (book == null) return NotFound(new { Message = "Book not found." });
            return Ok(book);
        }

        // POST: api/books
        [HttpPost]
        public IActionResult CreateBook([FromBody] Book newBook)
        {
            newBook.Id = books.Max(b => b.Id) + 1;
            books.Add(newBook);
            return CreatedAtAction(nameof(GetBookById), new { id = newBook.Id }, newBook);
        }

        // PUT: api/books/1
        [HttpPut("{id}")]
        public IActionResult UpdateBook(int id, [FromBody] Book updatedBook)
        {
            var book = books.FirstOrDefault(b => b.Id == id);
            if (book == null) return NotFound(new { Message = "Book not found." });

            book.Title = updatedBook.Title;
            book.Genre = updatedBook.Genre;
            book.AuthorId = updatedBook.AuthorId;

            return NoContent();
        }

        // DELETE: api/books/1
        [HttpDelete("{id}")]
        public IActionResult DeleteBook(int id)
        {
            var book = books.FirstOrDefault(b => b.Id == id);
            if (book == null) return NotFound(new { Message = "Book not found." });

            books.Remove(book);
            return NoContent();
        }
    }
}
