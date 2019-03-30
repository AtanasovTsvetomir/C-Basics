using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_SlotMachine
{
    class Program
    {
        static void Main(string[] args)
        {
            char n = char.Parse(Console.ReadLine());
            int n1 = int.Parse(Console.ReadLine());
            char m = char.Parse(Console.ReadLine());
            int m1 = int.Parse(Console.ReadLine());
            char k = char.Parse(Console.ReadLine());
            int k1 = int.Parse(Console.ReadLine());

            int firstSymbol = n + n1;
            int secondSymbol = m + m1;
            int thirdSymbol = k + k1;

            if (firstSymbol == 64 && secondSymbol == 64 && thirdSymbol == 64)
            {
                Console.WriteLine($"{(char)firstSymbol}{(char)secondSymbol}{(char)thirdSymbol}");
                Console.WriteLine($"! ! ! YOU LOSE THE GAME ! ! !");
            }
            else if (firstSymbol == 55 && secondSymbol == 55 && thirdSymbol == 55)
            {
                Console.WriteLine($"{(char)firstSymbol}{(char)secondSymbol}{(char)thirdSymbol}");
                Console.WriteLine($"*** JACKPOT ***");
            }
            else
            {
                Console.WriteLine($"{(char)firstSymbol}{(char)secondSymbol}{(char)thirdSymbol}");
            }
        }
    }
}