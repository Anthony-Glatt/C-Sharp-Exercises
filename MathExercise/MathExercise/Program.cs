using System;


namespace MathExercise
{
    class Program
    {
        static void Main()
        {   //Exercise 1 -----------------------------------------
            Console.WriteLine("Enter a number to have it multiplied by 50.");
            int input1 = Convert.ToInt32(Console.ReadLine()) * 50;
            Console.WriteLine("Total: " + input1);
            Console.ReadLine();

            //Exercise 2 -----------------------------------------
            Console.WriteLine("Enter a number to have 25 added to it.");
            int input2 = Convert.ToInt32(Console.ReadLine()) + 25;
            Console.WriteLine("Total: " + input2);
            Console.ReadLine();

            //Exercise 3 ------------------------------------------
            Console.WriteLine("Enter a number to have it divided by 12.5.");
            float input3 = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("Total: " + input3 / 12.5);
            Console.ReadLine();

            //Exercise 4--------------------------------------------
            Console.WriteLine("Enter a number to see if it is greater than 50.");
            bool input4 = Convert.ToInt32(Console.ReadLine()) > 50;
            Console.WriteLine("Answer: " + input4);
            Console.ReadLine();

            //Exercise 5 ---------------------------------------------
            Console.WriteLine("Enter a number to find its remainder when divided by 7");
            int input5 = Convert.ToInt32(Console.ReadLine()) % 7;
            Console.WriteLine("Remainder: " + input5);
            Console.ReadLine();

        }
    }
}
