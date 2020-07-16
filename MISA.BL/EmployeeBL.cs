using MISA.DL;
using MISA.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace MISA.BL
{
    public class EmployeeBL
    {
        public IEnumerable<Employee> GetEmployees()
        {
            EmployeeDL employeeDL = new EmployeeDL();
            return employeeDL.GetEmployees();
        }
    }
}
