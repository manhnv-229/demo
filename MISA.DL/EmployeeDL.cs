using MISA.DL.Interfaces;
using MISA.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MISA.DL
{
    public class EmployeeDL:BaseDL<Employee>,IEmployeeDL
    {
        public EmployeeDL(IDatabaseContext databaseContext) : base(databaseContext)
        {

        }
        /// <summary>
        /// Lấy các bản ghi đầu tiên theo tham số truyền vào
        /// </summary>
        /// <param name="limitTop">số lượng bản ghi muốn lấy</param>
        /// <returns></returns>
        /// CreatedBy: NVMANH (22/07/2020)
        public IEnumerable<Employee> GetTop10(int limitTop)
        {
            return GetData().ToList().Take(limitTop);
        }
    }
}
