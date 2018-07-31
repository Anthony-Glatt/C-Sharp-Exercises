using System;
using System.Collections.Generic;

namespace Exercise_Array_and_Lists
{
    class Program
    {
        static void Main()
        {// Exercise 1. Create a one-dimensional Array of strings. Ask the user to select an index of the Array and then display the string at that index on the screen.

            string[] array = { "Monkey", "Turtle", "Lion" };
            Console.WriteLine("Pick a number between 1 through 3.");
            int answer = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("That index location contains: " + array[answer - 1]);
            Console.ReadLine();

         //Exercise 2.Create a one-dimensional Array of integers.Ask the user to select an index of the Array and then display the integer at that index on the screen.

            int[] array1 = { 5, 10, 100 };
            Console.WriteLine("Pick a number between 1 through 3.");
            int answer1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("That index location contains: " + array1[answer1 - 1]);
            Console.ReadLine();

         //Exercise 3.Add in a message that displays when the user selects an index that doesn’t exist.
            Start:
            int[] array2 = { 5, 10, 100 };
            Console.WriteLine("Pick a number between 1 through 3.");
            int answer2 = Convert.ToInt32(Console.ReadLine());

            if (answer2 < 1 || answer2 > 3)
            {
                Console.WriteLine("The number you entered does not correspond to an index location.");
                Console.ReadLine();
                goto Start;
            }
            else
            {
                Console.WriteLine("That index location contains: " + array2[answer2 - 1]);
                Console.ReadLine();
            }

         //Exercise 4. Create a List of strings. Ask the user to select an index of the List and then display the content at that index on the screen.

            List<string> stringList = new List<string> { "bread", "milk", "cheese" };
            Console.WriteLine("Pick a number between 1 through 3.");
            int answer3 = Convert.ToInt32(Console.ReadLine()) - 1;
            Console.WriteLine("That index location contains: " + stringList[answer3]);
            Console.ReadLine();


        }
    }
}
