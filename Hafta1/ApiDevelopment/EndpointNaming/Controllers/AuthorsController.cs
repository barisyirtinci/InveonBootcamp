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
    public class AuthorsController : ControllerBase
    {
        private static List<Author> authors = new List<Author>
        {
            new Author { Id = 1, Name = "George Orwell", Bio = "Author of 1984 and Animal Farm" },
            new Author { Id = 2, Name = "Aldous Huxley", Bio = "Author of Brave New World" }
        };

        // GET: api/authors
        [HttpGet]
        public IActionResult GetAllAuthors()
        {
            return Ok(authors);
        }

        // GET: api/authors/1
        [HttpGet("{id}")]
        public IActionResult GetAuthorById(int id)
        {
            var author = authors.FirstOrDefault(a => a.Id == id);
            if (author == null) return NotFound(new { Message = "Author not found." });
            return Ok(author);
        }

        // POST: api/authors
        [HttpPost]
        public IActionResult CreateAuthor([FromBody] Author newAuthor)
        {
            newAuthor.Id = authors.Max(a => a.Id) + 1;
            authors.Add(newAuthor);
            return CreatedAtAction(nameof(GetAuthorById), new { id = newAuthor.Id }, newAuthor);
        }

        // PUT: api/authors/1
        [HttpPut("{id}")]
        public IActionResult UpdateAuthor(int id, [FromBody] Author updatedAuthor)
        {
            var author = authors.FirstOrDefault(a => a.Id == id);
            if (author == null) return NotFound(new { Message = "Author not found." });

            author.Name = updatedAuthor.Name;
            author.Bio = updatedAuthor.Bio;

            return NoContent();
        }

        // DELETE: api/authors/1
        [HttpDelete("{id}")]
        public IActionResult DeleteAuthor(int id)
        {
            var author = authors.FirstOrDefault(a => a.Id == id);
            if (author == null) return NotFound(new { Message = "Author not found." });

            authors.Remove(author);
            return NoContent();
        }
    }
}
