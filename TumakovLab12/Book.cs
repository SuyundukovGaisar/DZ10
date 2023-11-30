using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TumakovLab12
{
    internal class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public string Publisher { get; set; }
        public Book(string Title, string Author, string Publisher)
        {
            this.Title = Title;
            this.Author = Author;
            this.Publisher = Publisher;
        }
    }
}
