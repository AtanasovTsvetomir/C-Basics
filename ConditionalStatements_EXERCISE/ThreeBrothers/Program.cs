using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//Трима братя решили да изненадат баща си, като почистят заедно гаража му.Големият брат чисти сам за
//определени часове - А.Средният брат чисти сам за В часа.По-малкият брат чисти сам за С часа.Бащата отива
//да лови риба и няма да го има D часа.
//Напишете програма, която пресмята дали тримата братя могат да изчистят заедно гаража и да изненадат
//баща си или не.
//Към общото време за почистване се добавят 15% за почивка.
//Вход
//Входът се чете от конзолата и се състои от 4 реда:
// Времето на първият брат за чистене сам – реално число в интервала [0.00 … 99.00]
// Времето на вторият брат за чистене сам - реално число в интервала [0.00 … 99.00]
// Времето на третият брат за чистене сам - реално число в интервала [0.00 …99.00]
// Времето за риболов на бащата - реално число в интервала [0.00 … 99.00]
//Изход
//На конзолата трябва да се отпечата два реда.
//1. Времето за чистене и почивка, форматирано до втори знак: &quot; Cleaning time: {Времето за чистене }&quot;
//2. Има ли изненада или не:
// Ако братята СА изненадали бащата(time left &gt; 0): &quot;Yes, there is a surprise - time left
//-&gt; {остатък} hours.&quot; - резултата трябва да е закръглен към по-малко цяло число(пр. 1.90 -&gt; 1).
// Ако братята НЕ СА изненадали бащата: &quot;No, there isn&#39;сt a surprise - shortage of time -
//&gt; {недостиг} hours.&quot; - резултата трябва да е закръглен към по-голямо цяло число(пр. 1.10 -&gt; 2).


namespace ThreeBrothers
{
    class Program
    {
        static void Main(string[] args)
        {
            double firstBrother = double.Parse(Console.ReadLine());
            double secondBrother = double.Parse(Console.ReadLine());
            double thirdBrother = double.Parse(Console.ReadLine());
            double fatherTime = double.Parse(Console.ReadLine());

            double timeToCLeaning = 1 / (1 /firstBrother + 1 / secondBrother + 1 / thirdBrother);

            double timeToCleaningWithPause = timeToCLeaning  + (timeToCLeaning * 0.15);
            double surprise = fatherTime - timeToCleaningWithPause;

            Console.WriteLine($"Cleaning time: {timeToCleaningWithPause:f2}");
            if (surprise > 0)
            {
                Console.WriteLine($"Yes, there is a surprise - time left -> {Math.Floor(surprise)} hours.");
            }
            else
            {
                double needTime = Math.Abs(surprise);
                Console.WriteLine($"No, there isn't a surprise - shortage of time -> {Math.Ceiling(needTime)} hours.");
            }
        }
    }
}
