using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BirthdayExamLab
{
    class Program
    {
        static void Main(string[] args)
        {
            int lenght = int.Parse(Console.ReadLine());
            int widht = int.Parse(Console.ReadLine());
            int heihgt = int.Parse(Console.ReadLine());
            double percentage = double.Parse(Console.ReadLine()) / 100;

            double volume = lenght * widht * heihgt;
            double liters = volume / 1000;
            double litersInnedeed = liters - (liters * percentage);

            Console.WriteLine($"{litersInnedeed:f3}");
        }
    }
}
