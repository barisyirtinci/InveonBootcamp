using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Pagination.Models
{
    public class LibraryItem
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Type { get; set; }
        public string Author { get; set; }
    }
}
