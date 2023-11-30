using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TumakovLab12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Упражнение 12.1(создать и переопределить методы Equals, ==, !=, GetHashCode, ToString)");
            Account account1 = new Account(1000, AccountType.Current);
            Account account2 = new Account(5000, AccountType.Saving);
            Console.WriteLine(account1.Equals(account2)); 
            Console.WriteLine(account1 == account2);
            Console.WriteLine(account1 != account2);
            Console.WriteLine(account1.GetHashCode());
            Console.WriteLine(account1.ToString()); 
            Console.WriteLine(account2.ToString());
            Console.WriteLine();

            Console.WriteLine("Упражнение 12.2(cоздать класс рациональных чисел)");
            RationalNumber r1 = new RationalNumber(1, 2);
            RationalNumber r2 = new RationalNumber(3, 4);
            Console.WriteLine("Проверка на равенство: " + (r1 == r2));
            Console.WriteLine("Проверка на больше и меньше: " + (r1 < r2));
            Console.WriteLine("Результат сложения: " + (r1 + r2).ToString());
            Console.WriteLine("Результат вычитания: " + (r1 - r2).ToString());
            Console.WriteLine("Результат умножения: " + (r1 * r2).ToString());
            Console.WriteLine();

            Console.WriteLine("Домашнее задание 12.1(cоздать класс комплексных чисел)");
            ComplexNumber complex1 = new ComplexNumber(1, 2);
            ComplexNumber complex2 = new ComplexNumber(3, 4);
            Console.WriteLine("Результат сложения: " + (complex1 + complex2).ToString());
            Console.WriteLine("Результат вычитания: " + (complex1 - complex2).ToString());
            Console.WriteLine("Результат умножения: " + (complex1 * complex2).ToString());
            Console.WriteLine("Проверка на равенство: " + (complex1 == complex2));
            Console.WriteLine();

            Console.WriteLine("Домашнее задание 12.2(Написать делегат, с помощью которого реализуется сортировка книг.)");
            BookContainer container = new BookContainer();
            container.AddBook(new Book("Война и мир", "Толстой", "Русский вестник"));
            container.AddBook(new Book("Идиот", "Достоевский", "Русский вестник"));
            container.AddBook(new Book("Мертвые души", "Гоголь", "Современник"));
            //Сортировка по названию
            container.SortBooks((book1, book2) => book1.Title.CompareTo(book2.Title));
            container.PrintBooks();
            Console.WriteLine();
            //Сортировка по авторам
            container.SortBooks((book1, book2) => book1.Author.CompareTo(book2.Author));
            container.PrintBooks();
            Console.WriteLine();
            //Сортировка по издательствам
            container.SortBooks((book1, book2) => book1.Publisher.CompareTo(book2.Publisher));
            container.PrintBooks();
            Console.WriteLine();
        }
    }
}
