using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Exercise_Generics
{
    class Program
    {
        static void Main(string[] args)
        {
            //3. Instantiate an Employee object with type "string" as its generic parameter. Assign a list of strings as the property value of Things.
            Employee<string> EmployeeString = new Employee<string>();
            EmployeeString.Things = new List<string>(); 
            EmployeeString.Things.Add("Joe");
            EmployeeString.Things.Add("John");
            EmployeeString.Things.Add("Sam");

            //4. Instantiate an Employee object with type "int" as its generic parameter. Assign a list of integers as the property value of Things.
            Employee<int> EmployeeInt = new Employee<int>();
            EmployeeInt.Things = new List<int>();
            EmployeeInt.Things.Add(1);
            EmployeeInt.Things.Add(2);
            EmployeeInt.Things.Add(3);

            //5. Create a loop that prints all of the Things to the Console.
            foreach (string thing in EmployeeString.Things)
            {
                Console.WriteLine(thing);

            }
               
            foreach (int thing in EmployeeInt.Things)
            {
                Console.WriteLine(thing);
            }

            Console.ReadLine();




            //Employee employee1 = new Employee() { FirstName = "Bob", LastName = "Hay", Id = 2 };
            //Employee employee2 = new Employee() { FirstName = "Henry", LastName = "Jones", Id = 3 };

            //List<Employee> employeeList = new List<Employee>();
            //employeeList.Add(new Employee() { FirstName = "Bob", LastName = "Hay", Id = 2 });
            //employeeList.Add(new Employee() { FirstName = "Henry", LastName = "Jones", Id = 3 });

            //    bool compareId = (employee1.Id == employee2.Id);
            //    Console.WriteLine(compareId);
            //    employee1.SayName();
            //    employee2.SayName();

            //    Console.ReadLine();
        }
    }
}
