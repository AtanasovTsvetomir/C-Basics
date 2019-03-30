using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetricConventer
{
    class Program
    {
        static void Main(string[] args)
        {
            double number = double.Parse(Console.ReadLine());
            string inputMetric = Console.ReadLine();
            string outputMetric = Console.ReadLine();

            double firstUnit = 0;

            double m = 1;
            double mm = 1000;
            double cm = 100;
            double mi = 0.000621371192;
            double inches = 39.3700787;
            double km = 0.001;
            double ft = 3.2808399;
            double yd = 1.0936133;

            if (inputMetric == "m")
            {
                firstUnit = number / m;
            }
            else if (inputMetric == "mm")
            {
                firstUnit = number / mm;
            }
            else if (inputMetric == "cm")
            {
                firstUnit = number / cm;
            }
            else if (inputMetric == "mi")
            {
                firstUnit = number / mi;
            }
            else if (inputMetric == "inches")
            {
                firstUnit = number /inches;
            }
            else if (inputMetric == "km")
            {
                firstUnit = number / km;
            }
            else if (inputMetric == "ft")
            {
                firstUnit = number / ft;
            }
            else if (inputMetric == "yd")
            {
                firstUnit = number / yd;
            }

            double result = 0;

            if (outputMetric == "m")
            {
                result = firstUnit * m;
            }
            else if (outputMetric == "mm")
            {
                result = firstUnit * mm;
            }
            else if (outputMetric == "cm")
            {
                result = firstUnit * cm;
            }
            else if (outputMetric == "mi")
            {
                result = firstUnit * mi;
            }
            else if (outputMetric == "inches")
            {
                result = firstUnit *inches;
            }
            else if (outputMetric == "km")
            {
                result = firstUnit * km;
            }
            else if (outputMetric == "ft")
            {
                result = firstUnit * ft;
            }
            else if (outputMetric == "yd")
            {
                result = firstUnit * yd;
            }

            Console.WriteLine($"{result:F8}");
        }
    }
}
