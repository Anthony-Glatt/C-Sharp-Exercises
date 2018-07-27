using System;


namespace CarInsurance
{
    class Program
    {
        static void Main()
        {   //Find out if you qualify for car insurance based off of age, DUIs, and # of speeding tickets.
            Console.WriteLine("See if you qualify for car insurance!");
            Console.WriteLine();
            //User input
            Console.WriteLine("What is your age?");
            sbyte age = Convert.ToSByte(Console.ReadLine());
            Console.WriteLine("Have you ever had a DUI? Please answer \"True\" or \"False\".");
            bool dui = Convert.ToBoolean(Console.ReadLine());
            Console.WriteLine("How many speeding tickets do you have?");
            byte tickets = Convert.ToByte(Console.ReadLine());
            Console.WriteLine();
            //Logic for qualifying 
            Console.WriteLine("Do you qualify?");
            if (age > 15 && dui == false && tickets <= 3)
            {
                Console.WriteLine("True");
            }
            else
            {
                Console.WriteLine("False");
            }
            Console.ReadLine();

        }
    }
}
