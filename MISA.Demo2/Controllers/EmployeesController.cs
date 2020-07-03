using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MISA.Demo2.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MISA.Demo2.Controllers
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class EmployeesController : ControllerBase
    {
        /// <summary>
        /// Lấy danh sách nhân viên
        /// </summary>
        /// <returns></returns>
        /// CreatedBy: NVMANH (03/07/2020)
        [HttpGet]
        public IEnumerable<Employee> Get()
        {
            return Entity.ListEmployees;
        }

        [HttpGet("search")]
        public IActionResult GetEmployeeByCode([FromBody]string employeeCode, [FromQuery] int code)
        {
            var employee = Entity.ListEmployees.Where(emp => emp.EmployeeCode == employeeCode).FirstOrDefault();
            return Ok(employee);
        }

        [HttpPost]
        public IActionResult AddEmployee([FromBody] Employee employee)
        {
            Entity.ListEmployees.Add(employee);
            return BadRequest(true);

        }

        // PUT api/<EmployeesController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<EmployeesController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
