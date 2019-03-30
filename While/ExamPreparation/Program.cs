using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamPreparation
{
    class Program
    {
        static void Main(string[] args)
        {
            int maxPoorGrades = int.Parse(Console.ReadLine());
            double totalSum = 0;
            int counter = 0;
            string lastEx = string.Empty;
            int countOfPoorGrades = 0;

            while (true)
            {
                
                string exerciseName = Console.ReadLine();
                int grade = 0;
                if (exerciseName != "Enough")
                {
                    grade = int.Parse(Console.ReadLine());
                    counter++;
                    lastEx = exerciseName;
                }
                totalSum += grade;
                
            
                if (exerciseName == "Enough")
                {
                    double avg = totalSum / counter;
                    Console.WriteLine($"Average score: {avg:f2}");
                    Console.WriteLine($"Number of problems: {counter}");
                    Console.WriteLine($"Last problem: {lastEx}");
                    return;
                }
                if (grade <= 4)
                {
                    countOfPoorGrades++;
                }
                if (countOfPoorGrades == maxPoorGrades)
                {
                    Console.WriteLine($"You need a break, {countOfPoorGrades} poor grades.");
                    return;
                }
            }
        }
    }
}
