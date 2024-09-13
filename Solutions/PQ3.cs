using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeTasks.Solutions
{
    /*
     * Write a program that prints a table of conversion from Celsius (C) to Fahrenheit (F) 
     * for American visitors to Saskatchewan 
     * for temperatures ranging from -40 to +40 in increments of “inc”, 
     * where inc will be input by the user.
     * F = 9/5 * C + 32
     */
    /*internal class PQ3
    {
        static void Main(string[] args)
        {
            List<double> tempratureInCelsius = new List<double>();
            List<double> tempratureInFahrenheit = new List<double>();
            Console.Write("Welcome to Saskatchewan! Temperatures here range from -40 to 40 Celsius.\n I will print a table for you.");
            Console.Write("Input the inc: ");
            int inc = Convert.ToInt32(Console.ReadLine());

            CreateTempRange(inc, tempratureInCelsius);
            ConvertToFahrenheit(tempratureInCelsius, tempratureInFahrenheit);
            PrintTempratures(tempratureInCelsius, tempratureInFahrenheit);

            Console.ReadLine();
        }

        static void CreateTempRange(int inc, List<double> tempInCelsuis)
        {
            int count = -40;
            tempInCelsuis.Add(count);
            while (count < 40)
            {

                tempInCelsuis.Add(count + inc);
                count += inc;
                if (tempInCelsuis.Last() > 40)
                {
                    tempInCelsuis.RemoveAt(Convert.ToInt32(tempInCelsuis.Count) - 1);
                }
            }
        }

        static void ConvertToFahrenheit(List<double> tempInCelsuis, List<double> tempInFahrenheit)
        {
            for (int i = 0; i < tempInCelsuis.Count; i++)
            {
                // Note that in C# integer division will always return an integer instead of a float
                // Always explicitally declare the type to be returned
                double newTemp = ((9 / 5D) * tempInCelsuis[i]) + 32;
                tempInFahrenheit.Add(newTemp);
            }
        }

        static void PrintTempratures(List<double> tempInCelsuis, List<double> tempInFahrenheit)
        {
            Console.WriteLine("------------------------");
            Console.WriteLine("Celsuis\t\tFahrenheit");
            Console.WriteLine("------------------------");

            for (int i = 0; i < tempInFahrenheit.Count; i++)
            {
                Console.WriteLine($"{tempInCelsuis[i]: 0.00}\t\t{tempInFahrenheit[i]: 0.00}");
            }
        }
    }*/
}
