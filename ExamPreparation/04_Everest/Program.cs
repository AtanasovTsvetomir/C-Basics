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
            int input = 0;
            int total = 5364;
            int dayCount = 1;
            while (true)
            {
                string command = Console.ReadLine();
                if (command == "END")
                {
                    break;
                }
                if(command == "Yes")
                {
                    dayCount++;
                }
                if (dayCount > 5 || total >= 8848)
                {
                    break;
                }

                input = int.Parse(Console.ReadLine());
                total += input; 
            }
            if (total >= 8848)
            {
                Console.WriteLine($"Goal reached for {dayCount} days!");
            }
            else
            {
                Console.WriteLine($"Failed!");
                Console.WriteLine($"{total}");
            }
        }
    }
}
