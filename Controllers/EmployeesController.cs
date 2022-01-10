using System.Collections.Generic;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using TimeClock.Data;
using TimeClock.Dtos;
using TimeClock.Models;

namespace TimeClock.Controllers
{
    [Route("api/employees")]
    [ApiController]
    public class EmployeesController : ControllerBase
    {
        private readonly ITimeClockRepo _repository;
        private readonly IMapper _mapper;

        public EmployeesController(ITimeClockRepo repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        [HttpGet]
        public ActionResult<IEnumerable<Employee>> GetAllEmployees()
        {
            var employeeItems = _repository.GetEmployees();

            return Ok(employeeItems);
        }

        [HttpGet("{id}")]
        public ActionResult<EmployeeReadDto> GetEmployeeById(int Id)
        {
            var employeeItem = _repository.GetEmployeeById(Id);
            if(employeeItem != null)
            {
                return Ok(_mapper.Map<EmployeeReadDto>(employeeItem));
            }
            return NotFound();        
        }
    }
}