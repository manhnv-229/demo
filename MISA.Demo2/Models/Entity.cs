using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MISA.Demo2.Models
{
    public class Entity
    {
        public static List<Employee> ListEmployees = new List<Employee>()
        {
            new Employee("NV001","Nguyễn Văn Mạnh"),
            new Employee("NV002","Nguyễn Thị Mai"),
            new Employee("NV003","Nguyễn Thị Chim Bồ Câu Trắng"),
            new Employee("NV004","Trần Văn Hùng"),
            new Employee("NV005","Nguyễn Thị Thơm"),
            new Employee("NV006","Nông Văn Lắm")
        };
    }
}
