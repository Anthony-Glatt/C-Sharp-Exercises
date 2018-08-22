using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleCodeFirst
{
    class Program
    {
        static void Main(string[] args)
        {
            employeeOperation o = new employeeOperation();
            o.insertData();
        }
    }
    public class employeeOperation
    {
        public void insertData()
        {
            employee createEmployee = new employee();
            createEmployee.Employee_Id = 1;
            createEmployee.Employee_FirstName = "Adam";
            createEmployee.Employee_LastName = "Mada";
            createEmployee.Employee_Email = "adamM@company.com";
            createEmployee.Employee_Phone = "503-123-4567";
            EmployeeContext db = new EmployeeContext();
            db.employees.Add(createEmployee);
            db.SaveChanges();
            Console.WriteLine("Insert operation is success");
            Console.ReadLine();
        }
    }
}
