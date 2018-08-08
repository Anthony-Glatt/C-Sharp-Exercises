using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_Structs
{
    class Program
    {
        static void Main(string[] args)
        {
            //2. In the Main() method, create an object of data type Number and assign an amount to it.
            Number money = new Number();
            money.Amount = 1000000;

            //3. Print this amount to the console.
            Console.WriteLine("Amount equals " + money.Amount);
            Console.ReadLine();
        }
    }
}
