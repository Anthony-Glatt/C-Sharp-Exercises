using System;
using Exercise_Classes;

namespace Exercise_Classes_and_Methods2
{
    class Program
    {
        static void Main(string[] args)
        {
            // 2.In the Main() method of the console app, instantiate the class and call the one method, passing in an integer, such as 12. Then display the result to the screen.
            Class1.Method1(12);
            Console.ReadLine();

            //4. In the Main() method of the console app, instantiate the class and call the second method, passing in a decimal. Display the result to the screen.
            Class1.Method1(.5M);
            Console.ReadLine();

            //6. In the Main() method of the console app, instantiate the class and call the third method, passing in a string that equates to an integer. Display the result to the screen.
            Class1.Method1(8);
            Console.ReadLine();
        }
    }
}
