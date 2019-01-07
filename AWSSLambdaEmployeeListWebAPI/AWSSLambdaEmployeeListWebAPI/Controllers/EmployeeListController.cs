using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AWSSLambdaEmployeeListWebAPI.Models;
using AWSSLambdaEmployeeListWebAPI.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AWSSLambdaEmployeeListWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeListController : ControllerBase
    {
        private readonly IEmployeeListService empService;
        public EmployeeListController(IEmployeeListService empService)
        {
            this.empService = empService;
        }

        [HttpGet("getEmployee")]
        public IActionResult Get()
        {
           var listOfEmployee = empService.GetAllEmployeeFromTheList();
            return Ok(listOfEmployee);
        }
        [HttpPost("postEmployee")]
        public IActionResult post([FromBody]Employee emp)
        {
           empService.AddEmployee(emp);
            if(emp != null)
            {
                return Ok(emp);
            }
            else
            {
                //return null
                return Ok(new Employee());
            }
            
        }
        [HttpDelete("deleteEmployee")]
        public IActionResult delete(int id)
        {
            string result = empService.DeleteEmployeeById(id);
            return Ok(result);
        }
       
    }
}