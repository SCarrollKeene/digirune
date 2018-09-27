using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Digirune.Models
{
    public class Book
    {
        public int Id { get; set; }
        public string BookName { get; set; }
        public string Author { get; set; }
        public string Isbn { get; set; }
        public string Genre { get; set; }
        public CopyType Copies { get; set; }
    }
}
