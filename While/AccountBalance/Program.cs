using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountBalance
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());
            decimal inputMoney = 0;
            decimal totalMoney = 0;
            
            while (count > 0)
            {
                inputMoney = decimal.Parse(Console.ReadLine());
                if (inputMoney < 0)
                {
                    Console.WriteLine("Invalid operation!");
                    break; 
                }
                totalMoney += inputMoney;
                Console.WriteLine($"Increase: {inputMoney:F2}");
                count--;
            }
            Console.WriteLine($"Total: {totalMoney:F2}");
        }
    }
}
