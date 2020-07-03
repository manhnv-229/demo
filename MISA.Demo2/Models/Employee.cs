using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MISA.Demo2.Models
{
    public class Employee
    {
        public Employee()
        {

        }
        public Employee(string employeeCode, string employeeName)
        {
            EmployeeId = Guid.NewGuid();
            EmployeeCode = employeeCode;
            EmployeeName = employeeName;
            Birthday = DateTime.Now;
        }
        public string EmployeeName { get; set; }
        public string EmployeeCode { get; set; }
        public Guid? EmployeeId { get; set; }
        public DateTime Birthday { get; set; }
    }
}
