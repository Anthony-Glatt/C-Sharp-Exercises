using System;


namespace MathExercise2
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Anonymous Income Comparison Program");
            //Person 1 Info
            Console.WriteLine();
            Console.WriteLine("Person 1");
            Console.WriteLine("What is your hourly rate?");
            float person1Rate = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("How many hours do you work per week?");
            float person1Hours = Convert.ToSingle(Console.ReadLine());
            //Person 2 Info
            Console.WriteLine();
            Console.WriteLine("Person 2");
            Console.WriteLine("What is your hourly rate?");
            float person2Rate = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("How many hours do you work per week?");
            float person2Hours = Convert.ToSingle(Console.ReadLine());
            //Person 1 Annual Salary
            Console.WriteLine();
            float person1Annual = person1Rate * person1Hours * 52;
            Console.WriteLine("Annual salary of Person 1: $" + person1Annual);
            //Person 2 Annual Salary
            Console.WriteLine();
            float person2Annual = person2Rate * person2Hours * 52;
            Console.WriteLine("Annual salary of Person 2: $" + person2Annual);
            //Does person 1 make more?
            Console.WriteLine();
            Console.WriteLine("Does Person 1 make more money than Person 2?");
            bool comparison = person1Annual > person2Annual;
            Console.WriteLine(comparison);
            Console.ReadLine();
        }
    }
}
