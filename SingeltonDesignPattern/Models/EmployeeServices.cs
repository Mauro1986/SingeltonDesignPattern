using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingeltonDesignPattern.Models
{
    public class EmployeeServices
    {

        private static EmployeeServices instance;
        private List<Employee> employeeList = null;

        private static readonly object _lock = new object();

        private EmployeeServices()                        //bij Singelton is constructor PRIVATE(grootste verschil)
        {
            if (employeeList == null)
            {
                employeeList = new List<Employee>();
            }
        }

        public static EmployeeServices Instance()           // make instance only if instance is NULL
        {
            lock (_lock)                                    //lock nodig voor threadSafety!
            {
                if (instance == null)
                {
                    instance = new EmployeeServices();
                }
                return instance;
            }
        }

        public void AddEmployee(Employee employee)
        {
            employeeList.Add(employee);
        }

        public List<Employee> GetEmployee(string firstname)
        {
           return employeeList.FindAll(e => e.FirstName.Contains(firstname));
        }

        public List<Employee> GetAllEmployees()
        {
            return employeeList;
        }
    }
}
