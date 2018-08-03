using System;
using Exercise_Classes;

namespace Exercise_Classes_and_Methods4
{
    class Program
    {
        static void Main(string[] args)
        {
            //2. In the Main() method of the console app, instantiate the class.
           
            Class1 multiplication = new Class1();

            //3. Call the method in the class, passing in two numbers.

            multiplication.Method1(2, 5);

            //4. Call the method in the class, specifying the parameters by name.
            multiplication.Method1(num01: 10, num02: 200);
            Console.ReadLine();

        }
    }
}
