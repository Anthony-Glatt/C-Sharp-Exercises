using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_Abstract_Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            //5. Inside the Main() method, instantiate an Employee object with firstName "Sample" and lastName "Student". Call the SayName() method on the object.
            Employee employee1 = new Employee() { firstName = "Sample", lastName = "Student" };
            employee1.SayName();
            Console.ReadLine();
        }
    }
}
