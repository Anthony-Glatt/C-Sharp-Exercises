using System;
using Exercise_Classes;

namespace Exercise_Classes_and_Methods5
{
    class Program
    {
        static void Main(string[] args)
        {
            //2. In the Main() method, instantiate that class.
            Class1 divided = new Class1();

            //3. Have the user enter a number. Call the method on that number. Display the output to the screen. It should be the entered number, divided by two.
            Console.WriteLine("Please enter a number.");
            int userNumber = Convert.ToInt32(Console.ReadLine());

            divided.Method1(userNumber);
        }
    }
}
