﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise_Classes
{
    class Class1
    {
    public static void Method1 (int num01)
    {
            Console.WriteLine("Your number was added to 10 resulting in: " + (num01 + 10));
    }
    public static void Method2 (int num01)
        {
            Console.WriteLine("Your number was multiplied by 10 resulting in: " + num01 * 10);
        }
    public static void Method3 (int num01)
        {
            Console.WriteLine("Your number was divided by 10 resulting in: " + num01 / 10);
        }
    }
}
