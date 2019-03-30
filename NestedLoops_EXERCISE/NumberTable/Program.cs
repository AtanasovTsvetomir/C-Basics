using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberTable
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            int total = 0;
            for (int i = 0; i < num; i++)
            {
                for (int j = 0; j < num; j++)
                {
                    total = i + j + 1;
                    if (total > num)
                    {
                        total = 2 * num - total;
                    }
                    Console.Write($"{total} ");
                }
                Console.WriteLine();
            }
        }
    }
}
