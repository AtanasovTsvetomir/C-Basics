using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_ComputerRoom
{
    class Program
    {
        static void Main(string[] args)
        {
            string mounth = Console.ReadLine();
            double hoursCount = double.Parse(Console.ReadLine());
            double peopleCount = double.Parse(Console.ReadLine());
            string dayTime = Console.ReadLine();

            double price = 0.0;
            double total = 0.0;
            switch (mounth)
            {
                case "march":
                    switch (dayTime)
                    {
                        case "day":
                            price = 10.50;
                            break;
                        case "night":
                            price = 8.4;
                            break;
                    }
                    break;
                case "april":
                    switch (dayTime)
                    {
                        case "day":
                            price = 10.50;
                            break;
                        case "night":
                            price = 8.4;
                            break;
                    }
                    break;
                case "may":
                    switch (dayTime)
                    {
                        case "day":
                            price = 10.50;
                            break;
                        case "night":
                            price = 8.4;
                            break;
                    }
                    break;
                case "june":
                    switch (dayTime)
                    {
                        case "day":
                            price = 12.60;
                            break;
                        case "night":
                            price = 10.20;
                            break;
                    }
                    break;
                case "july":
                    switch (dayTime)
                    {
                        case "day":
                            price = 12.60;
                            break;
                        case "night":
                            price = 10.20;
                            break;
                    }
                    break;
                case "august":
                    switch (dayTime)
                    {
                        case "day":
                            price = 12.60;
                            break;
                        case "night":
                            price = 10.20;
                            break;
                    }
                    break;
            }
            if (peopleCount >= 4)
            {
                price = price * 0.90;
                total = price * peopleCount;
            }
            
            if (hoursCount >= 5)
            {
                price = price * 0.50;
                total = (price * hoursCount) * peopleCount;
            }
            else
            {
                total = (price * hoursCount) * peopleCount;
            }
            Console.WriteLine($"Price per person for one hour: {price:F2}");
            Console.WriteLine($"Total cost of the visit: {total:f2}");
        }
    }
}
