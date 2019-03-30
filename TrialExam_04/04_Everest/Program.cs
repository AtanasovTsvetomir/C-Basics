using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Everest
{
    class Program
    {
        static void Main(string[] args)
        {
            int days = 1;
            int metters = 5364;
           
            while (true)
            {
                string text = Console.ReadLine();

                if (text == "END")
                {
                    break;
                }
                if (text == "Yes")
                {
                    days++;
                }
                if (days > 5 || metters >= 8848)
                {
                    break;
                }
                int inputMetters = int.Parse(Console.ReadLine());
                metters += inputMetters;
            }
            
            if (metters >= 8848)
            {
                Console.WriteLine($"Goal reached for {days} days!");
            }
            else
            {
                Console.WriteLine("Failed!");
                Console.WriteLine($"{metters}");
            }
        }
    }
}
