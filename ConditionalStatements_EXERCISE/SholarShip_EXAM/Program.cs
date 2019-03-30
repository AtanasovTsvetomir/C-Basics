using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Учениците могат да кандидатстват за социална стипендия или за стипендия за отличен успех.Изискване за
//социална стипендия - доход на член от семейството по-малък от минималната работна заплата и успех над
//4.5. Размер на социалната стипендия - 35% от минималната работна заплата.Изискване за стипендия за
//отличен успех - успех над 5.5, включително.Размер на стипендията за отличен успех - успехът на ученика,
//умножен по коефициент 25.
//Напишете програма, която при въведени доход, успех и минимална работна заплата, дава информация дали
//ученик има право да получава стипендия, и стойността на стипендията, която е по-висока за него.
//Вход
//Потребителят въвежда 3 числа, по едно на ред:
//1. Доход в лева - реално число в интервала [0.00..6000.00]
//2. Среден успех - реално число в интервала [2.00...6.00]
//3. Минимална работна заплата - реално число в интервала [0.00..1000.00]
//Изход
// Ако ученикът няма право да получава стипендия, се извежда:
//You cannot get a scholarship!&quot;
//Ако ученикът има право да получава социална стипендия и тя е по-висока от стипендията за отличен
//успех:
//You get a Social scholarship {стойност на стипендия} BGN&quot;
//Ако ученикът има право да получава стипендия за отличен успех и тя е по-висока или равна по
//стойност на социалната стипендия за него:
//You get a scholarship for excellent results { стойност на стипендията }
//BGN&quot;
//Резултатът се закръгля до по-малкото цяло число.

namespace SholarShip_EXAM
{
    class Program
    {
        static void Main(string[] args)
        {
            double income = double.Parse(Console.ReadLine());
            double averageSuccess = double.Parse(Console.ReadLine());
            double minimumWorkSalary = double.Parse(Console.ReadLine());

            double socialSholarship = 0.35 * minimumWorkSalary;
            double specialScholarship = averageSuccess * 25;
            if (averageSuccess < 4.5)
            {
                Console.WriteLine("You cannot get a scholarship!");
            }
            else if ((averageSuccess >= 4.5) && (averageSuccess <= 5.5) && (income <= minimumWorkSalary))
            {
                Console.WriteLine($"You get a Social scholarship {Math.Floor(socialSholarship)} BGN");
            }
            else if ((averageSuccess < 5.5) && (income > minimumWorkSalary))
            {
                Console.WriteLine("You cannot get a scholarship!");
            }
            else  
            {

            if (income < minimumWorkSalary)
            {
                if (specialScholarship > socialSholarship)
                {
                    Console.WriteLine($"You get a scholarship for excellent results {Math.Floor(specialScholarship)} BGN");
                }
                else
                {
                    Console.WriteLine($"You get a Social scholarship {Math.Floor(socialSholarship)} BGN");
                }
            }
                else
                {
                    Console.WriteLine($"You get a scholarship for excellent results {Math.Floor(specialScholarship)} BGN");
                }
            }
        }
    }
}




