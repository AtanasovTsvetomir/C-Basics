using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumPrimeNumberNonPrimeNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            string numOrStop = Console.ReadLine();
            int primeSum = 0;
            int nonPriSum = 0;
            bool isPrime = true;
            
            for (int i = int.MinValue; i <= int.MaxValue; i++)
            {
                if (numOrStop == "stop")
                {
                    Console.WriteLine($"Sum of all prime numbers is: {primeSum}");
                    Console.WriteLine($"Sum of all non prime numbers is: {nonPriSum}");
                    return;
                }
                else
                {
                    int num = int.Parse(numOrStop);
                    if (num != 1)
                    {
                        if (num >= 0)
                        {
                            for (int j = 2; j < num; j++)
                            {
                                if (num % j == 0)
                                {
                                    isPrime = false;
                                }
                            }
                            if (isPrime)
                            {
                                primeSum += num;
                            }
                            else
                            {
                                nonPriSum += num;
                            }
                        }
                        else
                        {
                            Console.WriteLine("Number is negative.");
                        }

                    }
                    else
                    {
                        nonPriSum++;
                    }

                }
                numOrStop = Console.ReadLine();
                isPrime = true;
            }
        }
    }
}
