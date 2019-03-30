using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int begining = int.Parse(Console.ReadLine());
            int end = int.Parse(Console.ReadLine());

            for (int i = begining; i <= end; i++)
            {
                for (int j = begining; j <= end; j++)
                {
                    for (int k = begining; k <= end; k++)
                    {
                        for (int l = begining; l <= end; l++)
                        {
                            if ((i % 2 == 0) && (i > l) && ((j + k) % 2 == 0) && (l % 2 != 0))
                            {
                                Console.Write($"{i}{j}{k}{l} ");
                            }
                            else if ((i % 2 != 0) && (i > l) && ((j + k) % 2 == 0) && (l % 2 == 0))
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
