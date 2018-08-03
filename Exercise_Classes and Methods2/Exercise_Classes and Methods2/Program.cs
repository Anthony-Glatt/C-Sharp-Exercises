using System;
using Exercise_Classes;

namespace Exercise_Classes_and_Methods2
{
    class Program
    {
        static void Main(string[] args)
        {
            // 2.In the Main() method of the console app, instantiate the class and call the one method, passing in an integer, such as 12. Then display the result to the screen.
            Class1 addition = new Class1();
            int result1 = addition.Method1(12);
            Console.WriteLine(result1);
            Console.ReadLine();

            //4. In the Main() method of the console app, instantiate the class and call the second method, passing in a decimal. Display the result to the screen.
            Class1 division = new Class1();
            decimal result2 = division.Method1(.5M);
            Console.WriteLine(result2);
            Console.ReadLine();

            //6. In the Main() method of the console app, instantiate the class and call the third method, passing in a string that equates to an integer. Display the result to the screen.
            Class1 multiplication = new Class1();
            int result3 = multiplication.Method1(10);
            Console.WriteLine(result3);
            Console.ReadLine();
        }
    }
}
