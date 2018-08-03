using System;
using Exercise_Classes;

namespace Exercise_Classes_and_Methods4
{
    class Program
    {
        static void Main(string[] args)
        {
            //2. In the Main() method of the console app, instantiate the class.
            //3. Call the method in the class, passing in two numbers.
            Class1.Method1(10, 200);
            Console.ReadLine();

            //4. Call the method in the class, specifying the parameters by name.
            Class1.Method1(num01: 10, num02: 200);
            Console.ReadLine();

        }
    }
}
