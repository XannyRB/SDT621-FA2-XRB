using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SectionA_Question1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Decorative header
            Console.WriteLine("=====================================");
            Console.WriteLine("   STUDENT MARKS PROCESSING SYSTEM   ");
            Console.WriteLine("=====================================");
            Console.WriteLine();

            //Prompt user for input
            Console.Write("Enter student name: ");
            string studentName = Console.ReadLine();

            //Array to store the 3 subject marks
            double[] marks = new double[3];


            //Gather validate three subject marks
            for (int i = 0; i < 3; i++)
            {
                bool isValid = false;
                while (!isValid)
                {
                    Console.Write($"Enter mark for Subject {i + 1}: ");
                    string input = Console.ReadLine();

                    //Defensive Programming:numeric validation
                    if (double.TryParse(input, out double validatedMark))
                    {
                        //Range validation: marks should be between 0 and 100
                        if (validatedMark >= 0 && validatedMark <= 100)
                        {
                            marks[i] = validatedMark;
                            isValid = true;
                        }
                        else
                        {
                            Console.WriteLine("Invalid entry! Marks must be between 0 and 100.");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Invalid Input! Please enter a valid numeric value for the mark.");
                    }
                }
            }
            //Calculation logic
            double totalMarks = marks[0] + marks[1] + marks[2];
            double averageMarks = totalMarks / 3;

            //Decision Structure (Rule: Avegrage >= 50 = PASS)
            string resultStatus = (averageMarks >= 50) ? "PASS" : "FAIL";

            //Output formatting
            Console.WriteLine("\n==================================================");
            Console.WriteLine("                ASSESSMENT RESULTS                ");
            Console.WriteLine("==================================================");
            Console.WriteLine($"Student Name  : {studentName}");
            Console.WriteLine($"Total Marks   : {totalMarks:F2}");
            Console.WriteLine($"Average Marks : {averageMarks:F2}%");
            Console.WriteLine($"Final Status  : {resultStatus}");
            Console.WriteLine("==================================================");

            //Keep console open for screenshots
            Console.WriteLine("nPress any key to exit....");
            Console.ReadKey();
        }

    }
}
