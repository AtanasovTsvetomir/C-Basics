using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//Иванчо решава да подобри Световния рекорд по плуване на дълги разстояния.На конзолата се въвежда
//рекордът в секунди, който Иванчо трябва да подобри, разстоянието в метри, което трябва да преплува и
//времето в секунди, за което плува разстояние от 1 м.Да се напише програма, която изчислява дали се е
//справил със задачата, като се има предвид, че: съпротивлението на водата го забавя на всеки 15 м.с 12.5
//секунди.Да се изчисли времето в секунди, за което Иванчо ще преплува разстоянието и разликата спрямо
//Световния рекорд.
//Когато се изчислява колко пъти Иванчо ще се забави в резултат на съпротивлението на водата резултатът
//трябва да се закръгли надолу до най-близкото цяло число.
//Вход
//От конзолата се четат 3 реда:
//1. Рекордът в секунди – реално число в интервала [0.00 … 100000.00]
//2. Разстоянието в метри – реално число в интервала [0.00 … 100000.00]
//3. Времето в секунди, за което плува разстояние от 1 м. - реално число в интервала [0.00 … 1000.00]
//Изход
//Отпечатването на конзолата зависи от резултата:
// Ако Иванчо е подобрил Световния рекорд отпечатваме:
//o &quot; Yes, he succeeded! The new world record is {времето на Иванчо} seconds.&quot;
// Ако НЕ е подобрил рекорда отпечатваме:
//o &quot;No, he failed! He was { недостигащите секунди }
//seconds slower.&quot;

//Резултатът трябва да се форматира до втория знак след десетичната запетая.я.
    

namespace WorldSwimmingRecord_EXAM
{
    class Program
    {
        static void Main(string[] args)
        {
            double worldRecord = double.Parse(Console.ReadLine());
            double distanceInMetters = double.Parse(Console.ReadLine());
            double timeInSeconds = double.Parse(Console.ReadLine());

            double ivanRecordsWithSLow = Math.Floor(distanceInMetters / 15) * 12.5;
            double ivanRecords = (distanceInMetters * timeInSeconds) + ivanRecordsWithSLow;
            double secondsInneeded = ivanRecords - worldRecord;
            if (ivanRecords < worldRecord)
            {
                Console.WriteLine($"Yes, he succeeded! The new world record is {ivanRecords:f2} seconds.");
            }
            else
            {
                Console.WriteLine($"No, he failed! He was {secondsInneeded:f2} seconds slower.");
            }
        }
    }
}
