using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Student.Application;
using Student.Domain;
using Student.Infrastructure.Data;

namespace ProjectWeb.Api.Controllers
{
    [ApiController]
    [Route("api/Employee")]
    [Authorize]
    public class EmployeeController : Controller
    {

        private readonly IEmployeeService context;

        public EmployeeController(IEmployeeService _service)
        {
            context = _service;
        }

        //[HttpGet("using Linq methods")]
        //public async Task<IActionResult> GetEmployee()
        //{
        //    var result = await context.OrderBy(x => x.Salary).OrderByDescending(x => x.Name).Select(x => new
        //    {
        //        x.Name,
        //        x.Salary
        //    }).ToListAsync();

        //    if(result == null)
        //    {
        //        return BadRequest("Not Found");
        //    }
        //    return Ok(result);

        //}
        
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var result = await context.GetAll();

            return Ok(result);
        }

        // Get by Id
        [HttpGet("{id:int}")]
        public async Task<IActionResult> GetById([FromRoute] int id)
        {
            var result = await context.GetById(id);

            return Ok(result);
        }

        //Update the specific details
        [HttpPatch("{id:int}")]
        public async Task<IActionResult> UpdateDetails([FromRoute] int id,[FromBody] EmployeeDetails details)
        {
            var result=await context.UpdateDetails(id, details);

            if(result == null)
            {
                return BadRequest("No Employee Found");
            }
            return Ok(result);
        }

        [HttpPost]
        public  async Task<IActionResult> AddEmployee(EmployeeDetails details)
        {
            var result =  await context.AddNewEmployeeData(details);

            return Ok(result);
        }
    }
}
