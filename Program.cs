using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace PracticeTasks
{
    /*Write a program that prints a table of conversion from Celsius (C) to Fahrenheit (F) 
     * for American visitors to Saskatchewan 
     * for temperatures ranging from -40 to +40 in increments of “inc”, 
     * where inc will be input by the user.
     * F = 9/5 * C + 32
     */
    internal class Program 
    {
        static void Main(string[] args)
        {
            List<double> tempratures = new List<double> ();
            Console.Write("Welcome to Saskatchewan! Temperatures here range from -40 to 40 Celsius.\n I will print a table for you.");
            Console.Write("Input the inc: ");
            int inc = Convert.ToInt32(Console.ReadLine());

            CreateTempRange(inc, tempratures);

            Console.ReadLine();
        }

        static void CreateTempRange(int inc, List<double> temp)
        {
            int count = -40;
            temp.Add(count);
            while (count < 40) 
            {
                
                temp.Add (count + inc);
                count += inc;
                if (temp.Last() > 40)
                {
                    temp.RemoveAt(Convert.ToInt32(temp.Count) - 1);
                }
            }

            for (int i = 0; i < temp.Count; i++) 
            {
                Console.WriteLine(temp[i]);
            }
        }
    }


}
