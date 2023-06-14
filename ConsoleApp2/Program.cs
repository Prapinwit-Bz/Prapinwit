using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_Third
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int quantityOfStudent = 1;
            int[] Scorem, Scoren, Scoreb;
            string[] stud;

            // Firstly, The program ask the user about student quantity.
            Console.Write("How many students? : ");
            quantityOfStudent = int.Parse(Console.ReadLine()); // Convert 'string' from Console.ReadLine() to 'int'.

            // Secondly, re-allocating array sizing.
            stud = new string[quantityOfStudent];
            Scorem = new int[quantityOfStudent];
            Scoren = new int[quantityOfStudent];
            Scoreb = new int[quantityOfStudent];

            // Thirdly, The user key each student information.
            Console.WriteLine(":: Student Information ::");
            for (int iterator = 0; iterator < quantityOfStudent; iterator++)
            {
                // User feild student name, middle and final score information.
                Console.Write($"\nPlease key student({iterator + 1} of {quantityOfStudent}) name : ");
                stud[iterator] = Console.ReadLine();

                Console.Write($"Please key {stud[iterator]}'s middle score : ");
                Scorem[iterator] = Convert.ToInt32(Console.ReadLine());

                Console.Write($"Please key {stud[iterator]}'s final score : ");
                Scoren[iterator] = Convert.ToInt32(Console.ReadLine());

                // Score summation 
                Scoreb[iterator] = Scorem[iterator] + Scoren[iterator];
            }

            // Fourthly, We have to grades processing from each people's 'sumScore[]'. 
            Console.WriteLine("\n:: List of students and grades ::");
            int _ints = 0;

            do
            {
                float Scoregrades = 0.0f;   // This is the local variables in 'do..while' statement.

                #region Writng an if..else..if code without curly brackets type 1. 

                // For example, we use this region as defualt code.
                if (Scoreb[_ints] <= 49) Scoregrades = 0f;
                else if (Scoreb[_ints] <= 54) Scoregrades = 1f;
                else if (Scoreb[_ints] <= 59) Scoregrades = 1.5f;
                else if (Scoreb[_ints] <= 64) Scoregrades = 2f;
                else if (Scoreb[_ints] <= 69) Scoregrades = 2.5f;
                else if (Scoreb[_ints] <= 74) Scoregrades = 3f;
                else if (Scoreb[_ints] <= 79) Scoregrades = 3.5f;
                else if (Scoreb[_ints] >= 80) Scoregrades = 4f;

                #endregion

                

                Console.WriteLine($"{_ints + 1}. {stud[_ints]} have a" +
                                $" total {Scoreb[_ints]} score or {Scoregrades} grades.");
                _ints++;
            } while (_ints < quantityOfStudent);

            Console.Write("\nPress any key enter....");
            Console.ReadLine();
        }
    }
}