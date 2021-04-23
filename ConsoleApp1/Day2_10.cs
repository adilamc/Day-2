using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Employee
    {
        public int EmployeeId { get; set; }
        public string Name { get; set; }
    }
    class class8
    {

        static void Main(string[] args)
        {
            Employee emp = new Employee();
            emp.EmployeeId = 101;
            emp.Name = "Dummy1";
            Employee emp2 = new Employee();
            emp2.EmployeeId = 102;
            emp2.Name = "Dummy2";
            Console.WriteLine(emp.Equals(emp2));
            Console.WriteLine(Equals(emp,emp2));
            Console.ReadLine();

        }
    }
}
