using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LuckyNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= 9; i++)
            {
                for (int j = 1; j  <= 9; j++)
                {
                    for (int k = 1; k  <= 9; k++)
                    {
                        for (int l = 1; l <= 9; l++)
                        {
                            int leftSum = i + j;
                            int rightSum = k + l;

                            if (leftSum == rightSum && n % leftSum == 0)
                            {
                                Console.Write($"{i}{j}{k}{l} ");
                            }
                        }
                    }
                }
            }
        }
    }
}
