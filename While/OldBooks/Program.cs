using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OldBooks
{
    class Program
    {
        static void Main(string[] args)
        {
            string book = Console.ReadLine();
            int bookCapacity = int.Parse(Console.ReadLine());
            int count = 0;
            while (true)
            {
                string currentBook = Console.ReadLine();
                if (currentBook == book)
                {
                    Console.WriteLine($"You checked {count} books and found it.");
                    return;
                }
                count++;
                if (count == bookCapacity)
                {
                    Console.WriteLine("The book you search is not here!");
                    Console.WriteLine($"You checked {count} books.");
                    return;
                }
            }
            }
        }
    }

