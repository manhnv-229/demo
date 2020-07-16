using MISA.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MISA.DL
{
    public class EmployeeDL
    {
        public IEnumerable<Employee> GetEmployees()
        {
            DemoContext demoContext = new DemoContext();
            return demoContext.Employee.ToList();
        }
    }
}
