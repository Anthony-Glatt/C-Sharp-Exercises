using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_Additional_Features
{
    class Program
    {
        static void Main(string[] args)
        {
            //1. Create a const variable
            const string schoolName = "The Tech Academy";

            //2.Create a variable using the keyword "var".
            var startDate = "06/12/18";

           
            Console.WriteLine("Please enter your name.");
            string name = Console.ReadLine();
            Console.WriteLine("Please enter your favorite number.");
            int number = Convert.ToInt32(Console.ReadLine());
            FavoriteNumber object1 = new FavoriteNumber(name, number);
            FavoriteNumber object2 = new FavoriteNumber(name);
            Console.WriteLine(object1.userName +" is the name " + object1.userNumber + " is the number");
            Console.WriteLine(object2.userName + " is the same name " + object2.userNumber + " is the other number");
            Console.ReadLine();
        }
    }
}
