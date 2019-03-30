using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 5; i++)
            {
                if (i == 2 || i == 3)
                {
                    continue;
                }
                Console.WriteLine(i + " ");
            }
        }
    }
}
