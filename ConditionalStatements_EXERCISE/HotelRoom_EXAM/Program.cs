using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelRoom_EXAM
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputMonth = Console.ReadLine();
            int inputDays = int.Parse(Console.ReadLine());

            double MayAndOctoberStudio = 50;
            double MayAndOctoberApartament = 65;

            double JunyAndSeptemberStudio = 75.20;
            double JunyAndSeptemberApartament = 68.70;

            double JulyAndAugustStudio = 76;
            double JulyAndAugustApartament = 77;


            if ((inputMonth == "May") || (inputMonth == "October"))
            {
                if ((inputDays > 7) && (inputDays < 14))
                {
                    double reductionStudio = MayAndOctoberStudio - (0.05 * MayAndOctoberStudio);
                    Console.WriteLine($"Apartment: {MayAndOctoberApartament * inputDays:f2} lv.");
                    Console.WriteLine($"Studio: {reductionStudio * inputDays:f2} lv.");
                }
                else if (inputDays < 7)
                {
                    Console.WriteLine($"Apartment: {MayAndOctoberApartament * inputDays:f2} lv.");
                    Console.WriteLine($"Studio: {MayAndOctoberStudio * inputDays:f2} lv.");
                }
                else
                {
                    double reductionStudio = MayAndOctoberStudio - (0.3 * MayAndOctoberStudio);
                    double reductionApartament = MayAndOctoberApartament - (0.1 * MayAndOctoberApartament);
                    Console.WriteLine($"Apartment: {reductionApartament * inputDays:f2} lv.");
                    Console.WriteLine($"Studio: {reductionStudio * inputDays:f2} lv.");
                }
            }
            else if ((inputMonth == "June") || (inputMonth == "September"))
            {
                if (inputDays > 14)
                {
                    double reductionApartament = JunyAndSeptemberApartament - (0.1 * JunyAndSeptemberApartament);
                    double reductionStudio = JunyAndSeptemberStudio - (0.2 * JunyAndSeptemberStudio);
                    Console.WriteLine($"Apartment: {reductionApartament * inputDays:f2} lv.");
                    Console.WriteLine($"Studio: {reductionStudio * inputDays:f2} lv.");
                }
                else
                {
                    Console.WriteLine($"Apartment: {JunyAndSeptemberApartament * inputDays:f2} lv.");
                    Console.WriteLine($"Studio: {JunyAndSeptemberStudio * inputDays:f2} lv.");
                }
            }
            else if ((inputMonth == "July") || (inputMonth == "August"))
            {
                if (inputDays > 14)
                {
                    double reductionApartament = JulyAndAugustApartament - (0.1 * JulyAndAugustApartament);
                    Console.WriteLine($"Apartment: {reductionApartament * inputDays:f2} lv.");
                    Console.WriteLine($"Studio: {JulyAndAugustStudio * inputDays:f2} lv.");
                }
                else
                {
                    Console.WriteLine($"Apartment: {JulyAndAugustApartament * inputDays:f2} lv.");
                    Console.WriteLine($"Studio: {JulyAndAugustStudio * inputDays:f2} lv.");
                }
            }
        }
    }
}

