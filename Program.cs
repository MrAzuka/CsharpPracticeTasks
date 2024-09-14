using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace PracticeTasks
{
    /*
     * Write a program that prints out lines of stars, based on the values determined by the user-input. 
     * The program first asks for the minimum number of stars, the maximum number of stars, and the interval. 
     * It then prints lines of stars, starting with a line with the minimum number of stars, and ending with a line with the maximum number of stars. 
     * The increment of the number of stars is specified by the interval value. At the end of each line, it should also print how many stars are printed.
     */
    internal class Program 
    {
        static List<int> intervalList = new List<int>();
        static void Main(string[] args) 
        {
            try
            {
                Console.WriteLine("This program prints out stars");
                Console.Write("What is the maximum number of stars? ");
                int maxStars = Convert.ToInt32(Console.ReadLine());
                Console.Write("What is the minmum number of stars? ");
                int minStars = Convert.ToInt32(Console.ReadLine());
                Console.Write("What is the interval? ");
                int interval = Convert.ToInt32(Console.ReadLine());

                if (minStars > 0 && maxStars > 0 && interval > 0)
                {
                    CreateIntervals(interval,maxStars, minStars);

                }
                else
                {
                    Console.WriteLine("Number can't be less than 0");
                }
                Console.ReadLine();
            }
            catch (Exception)
            {

                throw new Exception("Number can't be less than 0");
            }
        }

        static void CreateIntervals(int interval, int max, int min)
        {
            try
            {
            Console.WriteLine();
            for (int i = min; i <= max; i+=interval) 
            {
                Console.WriteLine(new String('*', i) + $" ({i} stars)");
            }

            }
            catch (Exception ex)
            {

                 Console.WriteLine(ex.Message);
            }
        }
    }


}
