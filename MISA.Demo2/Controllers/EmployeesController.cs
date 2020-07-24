using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MISA.BL;
using MISA.BL.Interfaces;
using MISA.Demo2.Models;
using MISA.Entity;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MISA.Demo2.Controllers
{
    public class EmployeesController : BaseController<Employee>
    {
        public EmployeesController(IEmployeeBL employeeBL) : base(employeeBL)
        {

        }
        //public override ActionResult<IEnumerable<Employee>> GetData()
        //{
        //    EmployeeBL employeeBL = new EmployeeBL();
        //    return Ok(employeeBL.GetTop10(10));
        //}

        /// <summary>
        /// Lấy các bản ghi đầu tiên theo tham số truyền vào
        /// </summary>
        /// <param name="limitTop">số lượng bản ghi muốn lấy</param>
        /// <returns></returns>
        /// CreatedBy: NVMANH (22/07/2020)
        //[HttpGet("filter")]
        //public IEnumerable<Employee> GetTop10([FromQuery]int limitTop)
        //{
        //    EmployeeBL employeeBL = new EmployeeBL();
        //    return employeeBL.GetTop10(limitTop);
        //}
    }
}
