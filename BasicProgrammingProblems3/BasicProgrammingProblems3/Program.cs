using System;

namespace BasicProgrammingProblems3
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Declare my variables
             * Assign cookieCalories a Value
             * Allow for user inputCookies
             * Calculate totalCookies; inputCookies * cookieCalories
             * Display calculated values */
            
            Console.WriteLine("Enter the number of cookies ate:");

            //Console.ReadLine allows for user input in string form
            string inputCookies = Console.ReadLine();
            
            //Right now inputCookies is a string and to be change to be calculated
            // Parse allows for our inputCookies to be calculated
            double totalCookies = double.Parse(inputCookies);

            double totalCalories = (totalCookies * 67.3);

            Console.WriteLine($"Eating {inputCookies} is {totalCalories} Calories");
        }
    }
}
