﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise_Classes
{
    class Class1
    {
        public static void Method1(int num01, int num02)
        {
            //1. Create a class. In that class, create a void method that takes two integers as parameters. Have the method do a math operation on the first integer and display the second integer to the screen.
            Console.WriteLine(num01 + " multiplied by 10 equals: " + (num01 * 10));
            Console.WriteLine(num02 + " is the second number entered.");
        }
    }
}
