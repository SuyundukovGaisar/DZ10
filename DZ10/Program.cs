using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Задача 2(Написать программу для слежения за интересующим вас событием)");
            Dictionary<string, string> persons = new Dictionary<string, string>
            {
                { "Рома", "баскетбол" },
                { "Егор", "программирование" },
                { "Настя", "танцы"}
            };
            Console.WriteLine("Введите событие(после ввода нажмите enter): ");
            string eventName = Console.ReadLine();

            foreach (KeyValuePair<string, string> person in persons)
            {
                if (eventName.ToLower() == person.Value)
                {
                    Console.WriteLine($"{person.Key} заинтересован(а) в событии {eventName}!");
                }
                else
                {
                    Console.WriteLine($"{person.Key} не интересуется этим");
                }
            }
        }
    }
}
