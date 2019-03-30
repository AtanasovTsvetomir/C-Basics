using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_Salary
{
    class Program
    {
        static void Main(string[] args)
        {
            int openBrowsers = int.Parse(Console.ReadLine());
            int salary = int.Parse(Console.ReadLine());

            for (int i = 0; i < openBrowsers; i++)
            {
                string browser = Console.ReadLine();

                if (browser == "Facebook")
                {
                    salary -= 150;
                }
                else if (browser == "Instagram")
                {
                    salary -= 100;
                }
                else if (browser == "Reddit")
                {
                    salary -= 50;
                }
                if (salary <= 0)
                {
                    Console.WriteLine("You have lost your salary.");
                    return;
                }
            }
                Console.WriteLine(salary); 
        }
    }
}
