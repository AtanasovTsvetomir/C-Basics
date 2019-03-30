using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_TrekkingEquipment
{
    class Program
    {
        static void Main(string[] args)
        {
            int mountaineerCount = int.Parse(Console.ReadLine());
            int carabinersCount = int.Parse(Console.ReadLine());
            int ropeCount = int.Parse(Console.ReadLine());
            int picelleCount = int.Parse(Console.ReadLine());

            double sum = mountaineerCount * ((carabinersCount * 36) + (ropeCount * 3.60) + (picelleCount * 19.80));
            double totalSum = sum + (0.2 * sum);

            Console.WriteLine($"{totalSum:f2}");
        }
    }
}
