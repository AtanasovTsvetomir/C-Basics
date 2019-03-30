using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConcatenateData
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("first name: ");
            string name = Console.ReadLine();
            Console.WriteLine("last name: ");
            string lastName = Console.ReadLine();
            Console.WriteLine("Age: ");
            int age = int.Parse(Console.ReadLine());
            Console.WriteLine("City: ");
            string city = Console.ReadLine();

            Console.WriteLine($"You are {name} {lastName} and you are {age}-years old person, from {city} town.");

        }
    }
}
