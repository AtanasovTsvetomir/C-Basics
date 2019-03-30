using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrapeziodArea
{
    class Program
    {
        static void Main(string[] args)
        {
            //Напишете програма, която чете от конзолата три числа b1, b2 и h и пресмята лицето на трапец с основи b1 и
            // b2 и височина h. Формулата за лице на трапец е(b1 +b2) *h / 2.

            double b1 = double.Parse(Console.ReadLine());
            double b2 = double.Parse(Console.ReadLine());
            double h = double.Parse(Console.ReadLine());

            Console.WriteLine( (b1+b2)*h / 2);
        }
    }
}
