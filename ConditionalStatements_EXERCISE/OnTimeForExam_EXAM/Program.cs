using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Студент трябва да отиде на изпит в определен час(например в 9:30 часа). Той идва в изпитната зала в даден
//час на пристигане(например 9:40). Счита се, че студентът е дошъл навреме, ако е пристигнал в часа на
//изпита или до половин час преди това.Ако е пристигнал по-рано повече от 30 минути, той е подранил.Ако е
//дошъл след часа на изпита, той е закъснял.Напишете програма, която прочита време на изпит и време на
//пристигане и отпечатва дали студентът е дошъл навреме, дали е подранил или е закъснял и с колко часа или
//минути е подранил или закъснял.
//Вход
//От конзолата се четат 4 цели числа (по едно на ред), въведени от потребителя:
// Първият ред съдържа час на изпита – цяло число от 0 до 23.
// Вторият ред съдържа минута на изпита – цяло число от 0 до 59.
// Третият ред съдържа час на пристигане – цяло число от 0 до 23.
// Четвъртият ред съдържа минута на пристигане – цяло число от 0 до 59.
//Изход
//На първият ред отпечатайте:
// “Late”, ако студентът пристига по-късно от часа на изпита.
// “On time”, ако студентът пристига точно в часа на изпита или до 30 минути по-рано.
// “Early”, ако студентът пристига повече от 30 минути преди часа на изпита.
//Ако студентът пристига с поне минута разлика от часа на изпита, отпечатайте на следващия ред:
// “mm minutes before the start” за идване по-рано с по-малко от час.
// “hh:mm hours before the start” за подраняване с 1 час или повече.Минутите винаги печатайте с 2
//цифри, например “1:05”.
// “mm minutes after the start” за закъснение под час.
// “hh:mm hours after the start” за закъснение от 1 час или повече.Минутите винаги печатайте с 2 цифри,
//например “1:03”.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07OnTimeForTheExam
{
    class Program
    {
        static void Main(string[] args)
        {
            int examH = int.Parse(Console.ReadLine());
            int examM = int.Parse(Console.ReadLine());
            int arrH = int.Parse(Console.ReadLine());
            int arrM = int.Parse(Console.ReadLine());

            int examTimeInMin = (examH * 60) + examM;
            int arrTimeInMin = (arrH * 60) + arrM;

            if (examTimeInMin < arrTimeInMin)
            {
                Console.WriteLine("Late");

                int diff = arrTimeInMin - examTimeInMin;

                if (diff < 60)
                {
                    Console.WriteLine("{0} minutes after the start", diff);
                }

                else

                {
                    int diffMin = diff % 60;
                    int diffHrs = diff / 60;

                    Console.WriteLine("{0}:{1:D2} hours after the start", diffHrs, diffMin);
                }
            }
            else if (examTimeInMin == arrTimeInMin)
            {
                Console.WriteLine("On time");
            }
            else if (examTimeInMin - arrTimeInMin <= 30)
            {
                Console.WriteLine("On time");

                int diff = examTimeInMin - arrTimeInMin;
                Console.WriteLine("{0} minutes before the start", diff);
            }
            else if (examTimeInMin - arrTimeInMin > 30)
            {
                Console.WriteLine("Early");

                int diff = examTimeInMin - arrTimeInMin;

                if (diff < 60)
                {
                    Console.WriteLine("{0} minutes before the start", diff);
                }
                else

                {
                    int diffMin = diff % 60;
                    int diffHrs = diff / 60;

                    Console.WriteLine("{0}:{1:D2} hours before the start", diffHrs, diffMin);
                }
            }
        }
    }
}