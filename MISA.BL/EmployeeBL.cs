using MISA.BL.Interfaces;
using MISA.DL;
using MISA.DL.Interfaces;
using MISA.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MISA.BL
{
    public class EmployeeBL : BaseBL<Employee>, IEmployeeBL
    {
        public EmployeeBL(IEmployeeDL employeeDL) : base(employeeDL)
        {

        }
        ///// <summary>
        ///// Lấy các bản ghi đầu tiên theo tham số truyền vào
        ///// </summary>
        ///// <param name="limitTop">số lượng bản ghi muốn lấy</param>
        ///// <returns></returns>
        ///// CreatedBy: NVMANH (22/07/2020)
        //public IEnumerable<Employee> GetTop10(int limitTop)
        //{
        //    EmployeeDL employeeDL = new EmployeeDL();
        //    return employeeDL.GetTop10(limitTop);
        //}

        //public IEnumerable<Employee> GetTop10(int limitTop, string name)
        //{
        //    EmployeeDL employeeDL = new EmployeeDL();
        //    return employeeDL.GetTop10(limitTop).Where(e => e.FullName.Contains(name));
        //}

        //public IEnumerable<Employee> GetTop10(int limitTop, string name, string mobile)
        //{
        //    EmployeeDL employeeDL = new EmployeeDL();
        //    return employeeDL.GetTop10(limitTop).Where(e => e.FullName.Contains(name) && e.PhoneNumber == mobile);
        //}
    }
}
