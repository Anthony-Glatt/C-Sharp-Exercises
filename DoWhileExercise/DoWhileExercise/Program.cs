using System;

namespace DoWhileExercise
{
    class Program
    {
        static void Main() //2. Do a boolean comparison using a do while statement.
        {
            Console.WriteLine("What is the capital of Oregon?");
            Console.WriteLine("a.Portland");
            Console.WriteLine("b.Salem");
            Console.WriteLine("c.Eugene");
            Console.WriteLine("d.Newport");
            string choice = Console.ReadLine();

            do
            {
                Console.WriteLine("Enter your choice.");

                

                if ( Console.ReadLine().StartsWith("b"))
                {
                    Console.WriteLine("Correct!");
                    Console.ReadLine();
                    return;
                }
                else Console.WriteLine("Not quite.");
            }
            while (!Console.ReadLine().StartsWith("b"));
            Console.ReadLine();
        }
    }
} 
