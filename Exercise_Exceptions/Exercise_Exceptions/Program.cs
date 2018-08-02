using System;
using System.Collections.Generic;

namespace Exercise_Exceptions
{
    class Program
    {
        static void Main()
        {
            /* 1.Create a list of integers. Ask the user for a number to divide each number in the list by.Write a loop that takes 
                 each integer in the list, divides it by the number the user entered, and displays the result to the screen. */

            List<int> numberList = new List<int> { 5, 10, 15, 20 };

            Console.WriteLine("Please enter a number.");
            int userNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            Console.WriteLine("I have a list of numbers and will now divide them by your number...");
            Console.WriteLine();
            Console.WriteLine("Here are the the results of 5, 10, 15, and 20 divided by your number: ");

            foreach (int number in numberList)
            {
                Console.WriteLine(number / userNumber);
            }

            Console.ReadLine();

            /* 2. Now put the loop in a try/catch block. Below and outside of the try/catch block, make the program display a message to 
                  the display to let you know the program has emerged from the try/catch block and continued on with program execution. 
                  In the catch block, display the error message to the screen. Then try various combinations of user input: valid numbers, 
                  zero and a string. Ensure the proper error messages display on the screen, and that the code after the try/catch block gets executed. */

            try
            {
                Console.WriteLine("The program has begun.");
                Console.WriteLine();

                List<int> numberList = new List<int> { 5, 10, 15, 20 };

                Console.WriteLine("Please enter a number.");
                int userNumber = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine();

                Console.WriteLine("I have a list of numbers and will now divide them by your number...");
                Console.WriteLine();
                Console.WriteLine("Here are the the results of 5, 10, 15, and 20 divided by your number: ");

                foreach (int number in numberList)
                {
                    Console.WriteLine(number / userNumber);
                }

                Console.ReadLine();
            }

            catch (FormatException ex)
            {
                Console.WriteLine("Please enter a whole number. " + ex.Message);
            }

            catch (DivideByZeroException ex)
            {
                Console.WriteLine("Please do not divide by 0. " + ex.Message);
            }

            finally
            {
                Console.WriteLine("The program completed successfully.");
                Console.ReadLine();
            }
        }   
    }
}
