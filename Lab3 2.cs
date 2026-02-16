/*using System;
using System.Collections.Generic;
using System.Linq;
namespace CRabina 
{
    class Employees
    {

        class Employee
        {
            public string EmpName { get; set; }
            public int Salary { get; set; }
            public string Address { get; set; }
        }
        static void Main(string[] args)
        {
            List<Employee> list = new List<Employee>()
            {
                new Employee(){EmpName="Gita",Salary=40000 ,Address="Kathmandu"},
                new Employee(){EmpName="Rita",Salary=60000 ,Address="Pokhara"},
                new Employee(){EmpName="Mamata",Salary=100000 ,Address="Kathmandu"},
                new Employee(){EmpName="Rabina",Salary=80000 ,Address="Kathmandu"},
                new Employee(){EmpName="Sita",Salary=20000 ,Address="Dhading"}
            };
            var result = from emp in list
                         where emp.Salary > 50000 && emp.Address == "Kathmandu"
                         select emp.EmpName;
            Console.WriteLine("Employee names:");
            foreach (var name in result)
            {
                Console.WriteLine(name);
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}*/