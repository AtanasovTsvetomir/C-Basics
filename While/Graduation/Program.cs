using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Graduation
{
    class Program
    {
        static void Main(string[] args)
        {
            string studentName = Console.ReadLine();
            int grades = 1;
            double gradeSum = 0;

            while (grades <=12 )
            {
                double grade = double.Parse(Console.ReadLine());

                if (grade >= 4)
                {
                    grades++;
                    gradeSum += grade;
                }
            }
            Console.WriteLine($"{studentName} graduated. Average grade: {gradeSum / 12 :F2}");
        }
    }
}
