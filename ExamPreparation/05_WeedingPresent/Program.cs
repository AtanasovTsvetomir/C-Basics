using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_WeedingPresent
{
    class Program
    {
        static void Main(string[] args)
        {
            double maxGuest = double.Parse(Console.ReadLine());
            double giftCount = double.Parse(Console.ReadLine());

            int aCount = 0;
            int bCount = 0;
            int vCount = 0;
            int gCount = 0;

            double A = 0.0;
            double B = 0.0;
            double V = 0.0;
            double G = 0.0;
            double guestGift = 0.0;
            for (int i = 0; i < giftCount; i++)
            {
                string gift = Console.ReadLine();
                switch (gift)
                {
                    case "A":
                        aCount++;
                        break;
                    case "B":
                        bCount++;
                        break;
                    case "V":
                       vCount++;
                        break;
                    case "G":
                        gCount++;
                        break;
                }
                A = aCount / giftCount * 100;
                B = bCount / giftCount * 100;
                V = vCount / giftCount * 100;
                G = gCount / giftCount * 100;
                guestGift = giftCount / maxGuest * 100;
            }
            Console.WriteLine($"{A:f2}%");
            Console.WriteLine($"{B:f2}%");
            Console.WriteLine($"{V:f2}%");
            Console.WriteLine($"{G:f2}%");
            Console.WriteLine($"{guestGift:f2}%");
        }
    }
}
