using System;

namespace DailyReport
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("The Tech Academy");
            Console.WriteLine("Student Daily Report");
            Console.WriteLine();
            //Question 1----------------------------------------------
            Console.WriteLine("What course are you on?");
            string currentCourse = Console.ReadLine();
            //Question 2----------------------------------------------
            Console.WriteLine("What page number?");
            byte currentPage = Convert.ToByte(Console.ReadLine());
            //Question 3----------------------------------------------
            Console.WriteLine("Do you need help with anything? Please answer \"True\" or \"False\".");
            bool needHelp = Convert.ToBoolean(Console.ReadLine());
            //Question 4----------------------------------------------
            Console.WriteLine("Were there any positive experiences you'd like to share? Please give specifics.");
            string postiveExp = Console.ReadLine();
            //Question 5----------------------------------------------
            Console.WriteLine("Is there any feedback you'd like to provide? Please be specific.");
            string feedback = Console.ReadLine();
            //Question 6----------------------------------------------
            Console.WriteLine("How many hours did you study today?");
            byte hours = Convert.ToByte(Console.ReadLine());
            //Final Remark--------------------------------------------
            Console.WriteLine("Thank you for your answers. An instructor will respond to this shortly. Have a great day!");
            //Console.WriteLine(currentCourse + currentPage + needHelp + postiveExp + feedback + hours);
            Console.ReadLine();
        }
    }
}
