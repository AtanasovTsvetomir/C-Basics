using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Курсът &quot;Train the trainers&quot; е към края си и финалното оценяване наближава.Вашата задача е да помогнете на
//журито което ще оценява презентациите, като напишете програма в която да изчислява средната оценка от
//представянето на всяка една презентация от даден студент, а накрая средният успех от всички тях.
//От конзолата на първият ред се прочита броят на хората в журито n - цяло число в интервала [1…20]
//След това на отделен ред се прочита името на презентацията - текст
//За всяка една презентация на нов ред се четат n - на брой оценки - реално число в интервала [2.00…6.00]
//След изчисляване на средната оценка за конкретна презентация, на конзолата се печата
//&quot;{името на презентацията} - {средна оценка}.&quot;
//След получаване на команда &quot;Finish&quot; на конзолата се печата &quot;Student&#39;s final assessment is
//{среден успех от всички презентации}.&quot; и програмата приключва.
//Всички оценки трябва да бъдат форматирани до втория знак след десетичната запетая.

namespace TrainTheTrainers
{
    class Program
    {
        static void Main(string[] args)
        {
            int jury = int.Parse(Console.ReadLine());
            double examSum = 0;
            int counter = 0;
            double sumOfAllGrades = 0;

            while (true)
            {
                double totalSumOfAllGrades = sumOfAllGrades / counter;
                string name = Console.ReadLine();
                if (name == "Finish")
                {
                    Console.WriteLine($"Student's final assessment is {totalSumOfAllGrades:f2}.");
                    break;
                }
                else
                {
                    for (int j = 0; j < jury; j++)
                    {
                        double grade = double.Parse(Console.ReadLine());

                        examSum += grade;
                        sumOfAllGrades += grade;
                        counter++;

                    }
                }
                double totalExamSum = examSum / jury;
                Console.WriteLine($"{name} - {totalExamSum:f2}.");
                examSum = 0;
            }
        }
    }
}
