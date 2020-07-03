using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using MISA.Demo2.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MISA.Demo2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TeachersController : ControllerBase
    {
        // GET: api/<TeachersController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<TeachersController>/5
        [HttpGet("{id}/{test}")]
        public async Task<IActionResult> Get(int id,[FromBody] User user,[FromHeader(Name = "OrganizationId")] string organizationId,[FromServices]ILoginService loginService)
        {
            var login = await loginService.Login(user);
            if (login==true)
            {
                return Ok(loginService);
            }
            else
            {
                return BadRequest();
            }
        }

        // POST api/<TeachersController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<TeachersController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<TeachersController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
