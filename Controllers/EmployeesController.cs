using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using TimeClock.Data;
using TimeClock.Models;

namespace TimeClock.Controllers
{
    [Route("api/employees")]
    [ApiController]
    public class EmployeesController : ControllerBase
    {
        private readonly ITimeClockRepo _repository;

        public EmployeesController(ITimeClockRepo repository)
        {
            _repository = repository;
        }

        [HttpGet]
        public ActionResult<IEnumerable<Employee>> GetAllEmployees()
        {
            var employeeItems = _repository.GetEmployees();

            return Ok(employeeItems);
        }

        [HttpGet("{id}")]
        public ActionResult<Employee> GetEmployeeById(int Id)
        {
            var employeeItem = _repository.GetEmployeeById(Id);
            
            return Ok(employeeItem);
        }
    }
}