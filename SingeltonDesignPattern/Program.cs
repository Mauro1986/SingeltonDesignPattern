using SingeltonDesignPattern.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingeltonDesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee0 = new Employee {FirstName="Kenan", LastName="Kurda" };
            Employee employee1 = new Employee {FirstName="Mauro", LastName="Gay" };
            Employee employee2 = new Employee {FirstName="Timothy", LastName="Hsu" };
            Employee employee3 = new Employee {FirstName="Toon", LastName="Penen" };
            Employee employee4 = new Employee {FirstName="Francis", LastName="Bulu" };
            Employee employee5 = new Employee {FirstName="Emre", LastName="Elagoz" };

            EmployeeServices employeeServices = EmployeeServices.Instance();

            employeeServices.AddEmployee(employee0);
            employeeServices.AddEmployee(employee1);
            employeeServices.AddEmployee(employee2);
            employeeServices.AddEmployee(employee3);
            employeeServices.AddEmployee(employee4);
            employeeServices.AddEmployee(employee5);

            Employee e1 = new Employee { FirstName = "Mr", LastName = "Bean" };

            EmployeeServices employeeServices177777 = EmployeeServices.Instance();
            employeeServices177777.AddEmployee(e1);

            //var items = employeeServices.GetEmployee("Toon");

            //foreach (var item in items)
            //{
            //    Console.WriteLine($"First Name {item.FirstName}  Last Name: {item.LastName}");
            //}

            var allEmployees = employeeServices.GetAllEmployees();

            foreach (var item in allEmployees)
            {
                Console.WriteLine($"FirstName: {item.FirstName.PadRight(10)} LastName: {item.LastName.PadRight(25)}");
            }
        }
    }
}
