using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_SkiTrip
{
    class Program
    {
        static void Main(string[] args)
        {
            int dayCount = int.Parse(Console.ReadLine());
            string roomType = Console.ReadLine();
            string evaluation = Console.ReadLine();

            double sleepDay = dayCount - 1;
            double roomForOnePerson = 18.00 * sleepDay;
            double apartament = 25.00 * sleepDay;
            double presidentApartament = 35.00 * sleepDay;

            double sum = 0;

            switch (roomType)
            {
                case "room for one person":
                    if (dayCount < 10)
                    {
                        sum = roomForOnePerson;
                    }
                    else if (dayCount >= 10 && dayCount <= 15)
                    {
                        sum = roomForOnePerson;
                    }
                    else if (dayCount > 15)
                    {
                        sum = roomForOnePerson;
                    }
                    break;
                case "apartment":
                    if (dayCount < 10)
                    {
                        sum = apartament - (0.30 * apartament);
                    }
                    else if (dayCount >= 10 && dayCount <= 15)
                    {
                        sum = apartament - (0.35 * apartament);
                    }
                    else if (dayCount > 15)
                    {
                        sum = apartament - (0.50 * apartament);
                    }
                    break;
                case "president apartment":
                    if (dayCount < 10)
                    {
                        sum = presidentApartament - (0.10 * presidentApartament);
                    }
                    else if (dayCount >= 10 && dayCount <= 15)
                    {
                        sum = presidentApartament - (0.15 * presidentApartament);
                    }
                    else if (dayCount > 15)
                    {
                        sum = presidentApartament - (0.20 * presidentApartament);
                    }
                    break;

            }
            if (evaluation == "positive")
            {
                sum = sum + (0.25 * sum);
            }
            else if (evaluation == "negative")
            {
                sum = sum - (0.10 * sum);
            }
            Console.WriteLine($"{sum:f2}");
        }
    }
}
