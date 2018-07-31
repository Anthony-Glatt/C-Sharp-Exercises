using System;


namespace WhileExercise
{
    class Program
    {
        static void Main()       //1. Do a boolean comparison using a while statement.
        {
            Console.WriteLine("Guess a number between 1 - 10");
            int guess = Convert.ToInt32(Console.ReadLine());
            Random getRandom = new Random();
            int answer = getRandom.Next(0, 11);
            bool isGuessed = guess == answer;

            while (!isGuessed)
            {
                Console.WriteLine("Try Again.");
                guess = Convert.ToInt32(Console.ReadLine());

                if (answer == guess)
                {
                    Console.WriteLine("Congratulations, you guessed the number!");
                    Console.ReadLine();
                    return;
                }
            }
        }
    }
}