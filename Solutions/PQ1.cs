using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeTasks.Solutions
{
    /* Write a program that prints a table of how much volume of water a cylinder(with a radius r of 3 meters) is holding, 
    * as the height of water rises from 10 to N meters in increments of 2, 
    * where the value of N is input by the user(use the formula volume = PI * r^2 )*/
    /*internal class PQ1
    {
        static double Volume(int radius, int height)
        {
            return Math.PI * Math.Pow(radius, 2) * height;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("This displays the Volumes of a cyclinder from radius 3 meters\nand raises from height of 10 to N meters in increments of 2  ");
            Console.Write("Please input the value of N: ");
            int height = Convert.ToInt32(Console.ReadLine());
            int radius = 3;

            Console.WriteLine("-------------------");
            Console.WriteLine("Height \t Volume");
            Console.WriteLine("-------------------");
            for (int i = 10; i <= height; i += 2)
            {
                double result = Volume(radius, i);
                Console.WriteLine($"{i} \t {result: 0.00}");

            }

            Console.ReadLine();
        }
    }*/
}
