using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TumakovLab12
{
    internal class BookContainer
    {
        List<Book> books = new List<Book>();
        public delegate int BookComparer(Book book1, Book book2);
        public void AddBook(Book book)
        {
            books.Add(book);
        }
        public void SortBooks(BookComparer comparer)
        {
            books.Sort((book1, book2) => comparer(book1, book2));
        }
        public void PrintBooks()
        {
            foreach (Book book in books)
            {
                Console.WriteLine($"{book.Title} - {book.Author} - {book.Publisher}");
            }
        }
    }
}
