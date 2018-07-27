using System;


namespace ShippingQuote
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Welcome to the Package Express. Please follow the instructions below.");
            Console.WriteLine();
            Console.WriteLine("What is the weight of the package?");
            int weight = Convert.ToInt32(Console.ReadLine());

            if (weight > 50)
            {
                Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day.");
                Console.ReadLine();
                return;
            }
            Console.WriteLine("What is the width of the package?");
            int width = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("What is the height of the package?");
            int height = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("What is the length of the package?");
            int length = Convert.ToInt32(Console.ReadLine());
            int dimension = length * width * height;
            if (dimension > 50)
            {
                Console.WriteLine("Package too big to be shipped via Package Express. Have a good day.");
                Console.ReadLine();
                return;
            }

            int quote = (dimension * weight) / 100;


            Console.WriteLine("Your estimated total for shipping this package is: $" + quote + ".00");
            Console.WriteLine("Thank you.");
            Console.ReadLine();

        }
    }
}
