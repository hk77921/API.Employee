using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using API.Employee.Models;
using API.Employee.Context;

namespace API.Employee.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private readonly IPermamentEmployee _employeeRepository;
        private readonly ITemporaryEmployee _temporaryEmployee;

        public EmployeeController(IPermamentEmployee employeeRepository,ITemporaryEmployee temporaryEmployee)
        {
            _employeeRepository = employeeRepository;
            _temporaryEmployee = temporaryEmployee;
        }
       [HttpGet("AllEmployee")]
        public IActionResult GetEmployeeList()
        {
           // var allEmployee = _employeeRepository.GetEmployees().Concat(_temporaryEmployee.GetEmployees())
               
              
            return Ok();

        }


        // GET: api/<EmployeeController>
       [HttpGet("Permament")]
        public ActionResult<IEnumerable<PermanentEmployee>> getPermamentList()
        {
            return _employeeRepository.GetEmployees().ToList();
        }

        // GET api/<EmployeeController>/5
        [HttpGet("Permament/{id}")]
        public PermanentEmployee GetPermament(string id)
        {
            return _employeeRepository.GetEmployeeByID(id);
        }

        // POST api/<EmployeeController>
        [HttpPost("Permament")]
        public void AddPermamentEmp([FromBody] PermanentEmployee permanentEmployee)
        {
            _employeeRepository.InsertEmployee(permanentEmployee);
        }

        // PUT api/<EmployeeController>/5
        [HttpPut("Permament/{id}")]
        public void UpdatePermamentEmp( [FromBody] PermanentEmployee permanentEmployee)
        {
            _employeeRepository.UpdateEmployee(permanentEmployee);
        }

        // DELETE api/<EmployeeController>/5
        [HttpDelete("Permament/{id}")]
        public void DeletePermamentEmp(string id)
        {
            _employeeRepository.DeleteEmployee(id);
        }

        ///  For Temporary Employees
        
        // GET: api/<EmployeeController>
        [HttpGet("Temporary")]
        public ActionResult<IEnumerable<TemporaryEmployee>> getTemporaryList()
        {
            return _temporaryEmployee.GetEmployees().ToList();
        }

        // GET api/<EmployeeController>/5
        [HttpGet("Temporary/{id}")]
        public TemporaryEmployee Get(string id)
        {
            return _temporaryEmployee.GetEmployeeByID(id);
        }

        // POST api/<EmployeeController>
        [HttpPost("Temporary")]
        public void Post([FromBody] TemporaryEmployee  temporaryEmployee)
        {
            _temporaryEmployee.InsertEmployee(temporaryEmployee);
        }

        // PUT api/<EmployeeController>/5
        [HttpPut("Temporary/{id}")]
        public void Put([FromBody] TemporaryEmployee temporaryEmployee)
        {
            _temporaryEmployee.UpdateEmployee(temporaryEmployee);
        }

        // DELETE api/<EmployeeController>/5
        [HttpDelete("Temporary/{id}")]
        public void DeleteEmployee(string id)
        {
            _temporaryEmployee.DeleteEmployee(id);
        }
    }
}
