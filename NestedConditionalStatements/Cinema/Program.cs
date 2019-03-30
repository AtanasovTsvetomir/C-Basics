using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cinema
{
    class Program
    {
        static void Main(string[] args)
        {
            string projection = Console.ReadLine();
            int rowCounter = int.Parse(Console.ReadLine());
            int columnCounter = int.Parse(Console.ReadLine());

            double Premiere = 12.00;
            double Normal = 7.50;
            double Discount = 5.00;

            if (projection == "Premiere")
            {
                double total = Premiere * (rowCounter * columnCounter);
                Console.WriteLine($"{total:f2} leva");
            }
            else if (projection == "Normal")
            {
                double total = Normal * (rowCounter * columnCounter);
                Console.WriteLine($"{total:f2} leva");
            }
            else if (projection == "Discount")
            {
                double total = Discount * (rowCounter * columnCounter);
                Console.WriteLine($"{total:f2} leva");
            }
        }
    }
}
