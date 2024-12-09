using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Pagination.Models;

namespace Pagination.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class LibraryController : ControllerBase
    {
        // Büyük bir veri kümesini simüle eden statik liste
        private static List<LibraryItem> libraryItems = Enumerable.Range(1, 100)
            .Select(i => new LibraryItem
            {
                Id = i,
                Title = $"Library Item {i}",
                Type = i % 2 == 0 ? "Book" : "Magazine",
                Author = $"Author {i}"
            }).ToList();

        // GET: api/library?pageNumber=1&pageSize=10
        [HttpGet]
        public IActionResult GetPagedItems([FromQuery] int pageNumber = 1, [FromQuery] int pageSize = 10)
        {
            // Geçersiz girişlerin kontrolü
            if (pageNumber <= 0 || pageSize <= 0)
            {
                return BadRequest(new { Message = "Page number and page size must be greater than zero." });
            }

            // Sayfalama işlemi
            var totalItems = libraryItems.Count;
            var items = libraryItems
                .Skip((pageNumber - 1) * pageSize)
                .Take(pageSize)
                .ToList();

            // Sayfa bilgilerini döndürme
            var response = new
            {
                TotalItems = totalItems,
                PageNumber = pageNumber,
                PageSize = pageSize,
                TotalPages = (int)Math.Ceiling(totalItems / (double)pageSize),
                Items = items
            };

            return Ok(response);
        }
    }
}
