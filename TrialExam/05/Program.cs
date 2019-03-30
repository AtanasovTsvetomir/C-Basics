using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05
{
    class Program
    {
        static void Main(string[] args)
        {
            int passagersWhenBusGone = int.Parse(Console.ReadLine());
            int stopsCounter = int.Parse(Console.ReadLine());
            int passagersGone = 0;
            int passagersCome = 0;

            int passagersCounter = passagersWhenBusGone;

            for (int i = 1; i <= stopsCounter; i++)
            {
                passagersGone = int.Parse(Console.ReadLine());
                passagersCome = int.Parse(Console.ReadLine());

                passagersCounter = (passagersCounter - passagersGone) + passagersCome;
                if (i % 2 != 0)
                {
                    passagersCounter += 2;
                }
                else
                {
                    passagersCounter -= 2;
                }
            }
            Console.WriteLine($"The final number of passengers is : {passagersCounter}");
        }
    }
}
