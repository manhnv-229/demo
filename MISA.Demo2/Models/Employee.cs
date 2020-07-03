using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MISA.Demo2.Models
{
    public class Employee
    {
        public string EmployeeName { get; set; }
        public string EmployeeCode { get; set; }
        public Guid? EmployeeId { get; set; }
        public DateTime Birthday { get; set; }
    }
}
