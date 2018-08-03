using System;
using Exercise_Classes;

namespace Exercise_Classes_and_Methods3
{
    class Program
    {
        static void Main(string[] args)
        {
            // 2. In the Main() method of the console app, instantiate the class.
            Class1.Method1(5, 5);
            Console.ReadLine();

            //3. Ask the user to input two numbers, one at a time. Let them know they need not enter anything for the second number.
            Console.WriteLine("Please enter a number.");
            int userNum1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("If you would like, please enter in another number.");
            string userNum2 = Console.ReadLine();

            //4. Call the met hod in the class, passing in the one or two numbers entered.
            if (userNum2 == "")
            {
                Class1.Method1(userNum1);
                Console.ReadLine();
            }
            else
            {
                int userNumber2 = Convert.ToInt32(userNum2);
                Class1.Method1(userNum1, userNumber2);
                Console.ReadLine();
            }
            
        }
    }
}
