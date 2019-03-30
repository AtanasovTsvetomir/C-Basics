using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Time_15Minutes
{
    class Program
    {
        static void Main(string[] args)
        {
            int h = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());

            int minutes = m + 15;

            if (minutes > 59)
            {
                h++;
                minutes -= 60;
            }
            else if (h > 23)
            {
                h -= 23;
            }
            if (minutes < 10)
            {
                Console.WriteLine($"{h}:0{minutes}");
            }
            else
            {
                Console.WriteLine($"{h}:{minutes}");
            }
        }
    }
}
