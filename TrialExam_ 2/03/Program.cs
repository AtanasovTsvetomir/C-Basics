using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03
{
    class Program
    {
        static void Main(string[] args)
        {
            string nameOfClub = Console.ReadLine();
            string nameOfSouvenirs = Console.ReadLine();
            int souvenirsCounter = int.Parse(Console.ReadLine());

            double price = 0;

            switch (nameOfClub)
            {
                case "Argentina":
                    switch (nameOfSouvenirs)
                    {
                        case "flags":
                            price = 3.25;
                            break;
                        case "caps":
                            price = 7.20;
                            break;
                        case "posters":
                            price = 5.10;
                            break;
                        case "stickers":
                            price = 1.25;
                            break;
                    }
                    break;
                case "Brazil":
                    switch (nameOfSouvenirs)
                    {
                        case "flags":
                            price = 4.20;
                            break;
                        case "caps":
                            price = 8.50;
                            break;
                        case "posters":
                            price = 5.35;
                            break;
                        case "stickers":
                            price = 1.20;
                            break;
                    }
                    break;
                    case "Croatia":
                    switch (nameOfSouvenirs)
                    {
                        case "flags":
                            price = 2.75;
                            break;
                        case "caps":
                            price = 6.90;
                            break;
                        case "posters":
                            price = 4.95;
                            break;
                        case "stickers":
                            price = 1.10;
                            break;
                    }
                    break;
                case "Denmark":
                    switch (nameOfSouvenirs)
                    {
                        case "flags":
                            price = 3.10;
                            break;
                        case "caps":
                            price = 6.50;
                            break;
                        case "posters":
                            price = 4.80;
                            break;
                        case "stickers":
                            price = 0.90;
                            break;
                    }
                    break;
            }
            double totalSum = souvenirsCounter * price;
            if ((nameOfClub == "Argentina") || (nameOfClub == "Brazil") || (nameOfClub == "Croatia") || (nameOfClub == "Denmark"))
            {
                if ((nameOfSouvenirs == "flags") || (nameOfSouvenirs == "caps") || (nameOfSouvenirs == "posters") || (nameOfSouvenirs == "stickers"))
                {
                    Console.WriteLine($"Pepi bought {souvenirsCounter} {nameOfSouvenirs} of {nameOfClub} for {totalSum:f2} lv.");
                }
                else
                {
                    Console.WriteLine("Invalid stock!");
                }
            }
            else
            {
                Console.WriteLine("Invalid country!");
            }
        }
    }
}

