using System;

namespace Exercise_Classes_and_Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a number to have math operations performed on it.");
            int userInput = Convert.ToInt32(Console.ReadLine());

            Exercise_Classes.Class1.Method1(userInput);
            

            Exercise_Classes.Class1.Method2(userInput);
            

            Exercise_Classes.Class1.Method3(userInput);
            Console.ReadLine();
        }
    }
}
