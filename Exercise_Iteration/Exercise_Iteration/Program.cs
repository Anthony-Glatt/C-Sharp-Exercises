using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Exercise_Iteration
{
    class Program
    {
        static void Main()
        {
            /* 1. Create a one-dimensional Array of strings. Ask the user to input some text. Create a loop that goes through each 
                 string in the Array, adding the user’s text to the string. Then create a loop that prints off each string in the 
                 Array on a separate line.*/

            string[] titles = { "King", "Queen", "Emperor", "Lord", "President", "Prime Minister" };

             Console.WriteLine("Enter your name.");
             string userName = Console.ReadLine();

             foreach (string title in titles)
             {
                 Console.WriteLine(title + " " + userName);
             }

             Console.ReadLine();

            // 2. Create an infinite loop.
        
            int i = 1;
            while (i > 0)
            {
                Console.WriteLine("Oh no it's infinite!");
            }
            Console.ReadLine();

            // 3. Fix the infinite loop so it will execute.
             int i = 1;
             while (i > 0)
             {
                 Console.WriteLine("Oh no it's infinite!");
                 i--;
                 Console.WriteLine("Just kidding");
             }
             Console.ReadLine();

            // 4. Create a loop where the comparison used to determine whether to continue iterating the loop is a “<” operator.
            int i = 1;
            while (i < 5)
            {
                Console.WriteLine("Ello Govener.");
                i++;
            }
            Console.ReadLine();

            // 5. Create a loop where the comparison used to determine whether to continue iterating the loop is a “<=” operator.
            int i = 1;
            while (i <= 5)
            {
                Console.WriteLine("Ello Govener.");
                i++;
            }
            Console.ReadLine();

            /* 6. Create a List of strings where each item in the list is unique. Ask the user to select text to search for in the List. 
                  Create a loop that iterates through the loop and then displays the index of the array that contains matching text on the screen. */

             List<string> animals = new List<string> { "Tiger", "Rhino", "Bobcat", "Bat" };

             Console.WriteLine("Enter one of the following animals: Tiger, Rhino, Bobcat, or Bat.");
             string userPick = Console.ReadLine();

             foreach (string animal in animals)
             {
                 if (animal == userPick)
                 {
                     Console.WriteLine(animals.IndexOf(userPick));
                 }
             }
             Console.ReadLine();

            // 7. Add code to that above loop that tells a user if they put in text that isn’t in the List.

            List<string> animals = new List<string> { "Tiger", "Rhino", "Bobcat", "Bat" };

             Console.WriteLine("Enter one of the following animals: Tiger, Rhino, Bobcat, or Bat.");
             string userPick = Console.ReadLine();

             foreach (string animal in animals)
             {
                 if (animal == userPick)
                 {
                     Console.WriteLine(animals.IndexOf(userPick));
                 }
                 else Console.WriteLine("Sorry, but what you entered is not on the list.");

             } 
             Console.ReadLine();

            // 8. Add code to that above loop that stops it from executing once a match has been found.
            List<string> animals = new List<string> { "Tiger", "Rhino", "Bobcat", "Bat" };

            Console.WriteLine("Enter one of the following animals: Tiger, Rhino, Bobcat, or Bat.");
            string userPick = Console.ReadLine();

            foreach (string animal in animals)
            {
                if (animal == userPick)
                {
                    Console.WriteLine(animals.IndexOf(userPick));
                    break;
                }
            }
            Console.ReadLine();

            /* 9. Create a List of strings that has at least two identical strings in the List. Ask the user to select text to search for in the List. 
                  Create a loop that iterates through the loop and then displays the indices of the array that contain matching text on the screen. */

            List<string> animals = new List<string> { "Bear", "Bear", "Cougar", "Eagle" };

             Console.WriteLine("Enter one of the following animals: Bear, Cougar or Eagle.");
             string userPick = Console.ReadLine();

             for (int i = 0; i < animals.Count; i++)
             {
                 if (userPick == animals[i])
                 {
                     Console.WriteLine("The index location is: " + animals.IndexOf(userPick));
                 }
             }
             Console.ReadLine();

            // 10. Add code to that above loop that tells a user if they put in text that isn’t in the List.

             List<string> animals = new List<string> { "Bear", "Bear", "Cougar", "Eagle" };

             Console.WriteLine("Enter one of the following animals: Bear, Cougar or Eagle.");
             string userPick = Console.ReadLine();

             for (int i = 0; i < animals.Count; i++)
             {
                 if (userPick == animals[i])
                 {
                     Console.WriteLine("The index location is: " + animals.IndexOf(userPick));
                 }
                 else Console.WriteLine("What you entered is not on the list.");
             }
             Console.ReadLine();

            /* 11. Create a List of strings that has at least two identical strings in the List. Create a foreach loop that evaluates each item in the list, 
                    and displays a message showing the string and whether or not it has already appeared in the list. */

            List<StringBuilder> presidents = new List<StringBuilder>(); //{ "Bush", "Clinton", "Bush", "Obama" };
            presidents.Add(new StringBuilder("Bush"));
            presidents.Add(new StringBuilder("Clinton"));
            presidents.Add(new StringBuilder("Bush"));
            presidents.Add(new StringBuilder("Obama"));
            presidents.Add(new StringBuilder("Lincoln"));
            presidents.Add(new StringBuilder("Washington"));
            presidents.Add(new StringBuilder("Bush"));
            presidents.Add(new StringBuilder("Kennedy"));
            presidents.Add(new StringBuilder("Carter"));
            presidents.Add(new StringBuilder("Clinton"));

            int count = 0;

            foreach (StringBuilder president in presidents)
            {
                for (int i = 0; i < presidents.Count(); i++)
                {
                    if (presidents.ElementAt(i).ToString().Contains(president.ToString())) count++;
                }

                if (count > 1) president.Append(" (REDUNDANT)");
                count = 0;
            }
            foreach (StringBuilder president in presidents)
            {
                Console.WriteLine(president + "\n");
            }
            Console.ReadLine();
        }
    }
}