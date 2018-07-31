using System;
using System.Text;

namespace StringPractice
{
    class Program
    {
        static void Main(string[] args)
        {
         //Exercise 1.Concatenate three strings --------------------------------------------------
            string title = "King";
            string fName = "Henry";
            string iteration = "VIII";

            //Adding spaces between the strings
            fName = " " + fName;
            iteration = " " + iteration;

            Console.WriteLine("His majesty, {0}!", string.Concat(title, fName, iteration));
            Console.ReadLine();

            //Exercise 2.Convert a string to uppercase------------------------------------------------
           string word = "hello";
            word = word.ToUpper();

            Console.WriteLine(word);
            Console.ReadLine();

            //Exercise 3. Create a Stringbuilder and build a paragraph of text, one sentence at a time ------
            StringBuilder sb = new StringBuilder();
            sb.Append(" Hi! My name is Anthony and I am working hard to become a Software Developer.");
            sb.Append(" While I am new to programming, I have \n come prepared with a powerful skill.");
            sb.Append(" That skill is my ability to efficiently learn new detail dense material.");
            sb.Append(" With \n such a skill I am confident that I will become a Software Developer!");
            Console.WriteLine(sb);
            Console.ReadLine();
        }


    }
}
