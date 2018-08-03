using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise_Classes
{
    class Class1
    {
        // 1. Create a class. In that class, create a method that will take in an integer, do a math operation to it and then return the answer as an integer.
        public static void Method1(int num01)
        {
            Console.WriteLine("Your number added to 20 equals: " + (num01 + 20));
        }

        //3. Add a second method to the class, with the same name, that will take in a decimal, do a different math operation to it and then return the answer as an integer.
        public static void Method1(decimal num01)
        {
            Console.WriteLine("Your number divided by 10 equals: " + (num01 / 10));
        }

        //5. Add a third method to the class, with the same name, that will take in a string, convert it to an integer if possible, do a different math operation to it and then return the answer as an integer.
        public static void Method1(string num01)
        {   int num02 = Convert.ToInt32(num01);
            Console.WriteLine("Your number mutliplied by 10 equals: " + (num02 * 10));
        }
    }
}
