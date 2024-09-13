using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeTasks.Solutions
{
    /*
     * Write a program that:
         •	reads a number N
         •	uses one array of Strings of length N to store student names, an array of doubles of length N to store the marks in the midterm (marks range from 0-100 and weighted 35% of total), 
            and an array of doubles to store the marks in final examination (marks range from 0-100 and weighted 65% of total)
         •	reads a list of student names, midterm and final examination marks, stores them in the corresponding arrays
         •	calculates the total marks for each student
         •	keeps track of the sum of marks for the midterm and final examination
         •	prints all student names, midterm, final examination, and total marks, as well as the grade in a table
         •	At the end, prints the average for midterm, final examination, and total marks, as well as the average grade
     */
    /*internal class PQ2
    {
        static void Main(string[] args)
        {
            int i = 0;
            while (i < 1)
            {
                try
                {
                    Console.Write("Input the number of Students: ");
                    int NumberOfStudents = Convert.ToInt32(Console.ReadLine());

                    string[] names = new string[NumberOfStudents];
                    double[] midterms = new double[NumberOfStudents];
                    double[] finalexams = new double[NumberOfStudents];

                    ReadInputs(NumberOfStudents, names, midterms, finalexams);
                    CalculateScores(names, midterms, finalexams);
                    CalculateAverage(midterms, finalexams);
                    Console.ReadLine();
                    i++;
                }
                catch (Exception e)
                {
                    Console.WriteLine($"Error: {e.Message}");
                    *//*Console.ReadLine();*//*
                }
            }
        }

        static void ReadInputs(int n, string[] names, double[] midterms, double[] finalexams)
        {
            for (int i = 0; i < n; i++)
            {
                Console.Write("Input the name: ");
                names[i] = Convert.ToString(Console.ReadLine());
                Console.Write("Input the midterm score: ");
                midterms[i] = Convert.ToDouble(Console.ReadLine());
                Console.Write("Input the exam score: ");
                finalexams[i] = Convert.ToDouble(Console.ReadLine());

                bool check = (0 <= midterms[i] && midterms[i] <= 100) && (0 <= finalexams[i] && finalexams[i] <= 100);
                if (!check)
                {
                    throw new Exception("Scores cannot be less than 0 or greater than 100");
                }
            }
        }

        static void CalculateScores(string[] names, double[] midterms, double[] finalexams)
        {
            Console.WriteLine("----------------------------------------------------------------");
            Console.WriteLine("Name\t\tMidterm\t\tExam\t\tTotal Score");
            Console.WriteLine("----------------------------------------------------------------");
            for (int i = 0; i < names.Length; i++)
            {
                double totalmarks = (midterms[i] * 0.35) + (finalexams[i] * 0.65);
                Console.WriteLine($"{names[i]}\t\t{midterms[i]}\t\t{finalexams[i]}\t\t{totalmarks}");
            }

        }

        static void CalculateAverage(double[] midterms, double[] finalexams)
        {
            double totalmidtermmarks = 0;
            double totalexammarks = 0;
            double totalmarks = 0;

            for (int i = 0; i < midterms.Length; i++)
            {
                totalmidtermmarks += midterms[i];
                totalexammarks += finalexams[i];
                totalmarks += (midterms[i] * 0.35) + (finalexams[i] * 0.65);
            }

            totalexammarks = totalexammarks / midterms.Length;
            totalmidtermmarks = totalmidtermmarks / midterms.Length;
            totalmarks = totalmarks / midterms.Length;
            Console.WriteLine("----------------------------------------------------------------");
            Console.WriteLine($"Average\t\t{totalmidtermmarks}\t\t{totalexammarks}\t\t{totalmarks}");
            Console.WriteLine("----------------------------------------------------------------");


        }
    }*/
}
