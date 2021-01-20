using System;

namespace ConditionStatements
{
    class Program
    {
        static void Main(string[] args)
        {
            const int MIN_NUMBER = 1;
            const int MAX_NUMBER = 9;

            Random keyrand = new Random();

            int number1 = keyrand.Next(MIN_NUMBER, MAX_NUMBER + 1):
            int number2 = keyrand.Next(MIN_NUMBER, MAX_NUMBER + 1):

            Console.Write($"The sum of {number1} + {number2} = ?\t");

            int answer = int.Parse(Console.ReadLine());
            //the conditional test is (number1 + number2) == answer
            //where the left arguement is (number1 + number2)
            //      the relational operator is == (equals)
            //      the right arguement is the answer
            //this condition will resolve to either true or false
            Console.WriteLine($"{number1} + {number2} = {answer}" +
                $"your answer is {(number1 + number2) == answer}");

            //the one--way if statement
            //has only a true path
            double radius = 4.5
            if (radius > 0)
            {
                double area = Math.Pow(radius, Math.PI);
                Console.WriteLine($"The area of a circle with a radius of {radius} is {Math.Round(area, 2)}");
            }

            //a two-way if statement
            //has a true path and a false path
            //the true path is coded first
            //the flase path is coded second
            //the true path coding block is seperated from the false path
            //      coding block by the key word -> else
            double radius = 4.5
            if (radius > 0)
            {
                double area = Math.Pow(radius, Math.PI);
                if (area >= 100.0)
                {
                    //true path
                    //executed when the condition resolves to the boolean value TRUE
                    Console.WriteLine($"The area of a circle with a radius of {radius} is " +
                        $"{Math.Round(area, 2)}. Your circle is large enough");

                    //at the end of this TRUE coding block you exit to the 
                    //  next statement AFTER the end of the if
                }
                else
                {
                    //false path
                    //executed when the condition resolves to the boolean value FALSE
                    Console.WriteLine($"The area of a circle with a radius of {radius} is " +
                        $"{Math.Round(area, 2)}. Increase the size of the radius");

                    //at the end of this FALSE coding block you exit to the 
                    //  next statement AFTER the end of the if
                } //this closing bracket indicates the end of the two way if
                Console.WriteLine("This is the next statement after the two way if");
            

            }
        }
    }
}
