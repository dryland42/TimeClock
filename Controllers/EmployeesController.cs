using System.Collections.Generic;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using TimeClock.Data;
using TimeClock.Dtos;
using TimeClock.Models;
using System.Linq;

namespace TimeClock.Controllers
{
    [Route("api/employees")]
    [ApiController]
    public class EmployeesController : ControllerBase
    {
        private readonly ITimeClockRepo _repository;
        private readonly IMapper _mapper;
        private readonly TimeClockContext _context;

        public EmployeesController(ITimeClockRepo repository, IMapper mapper, TimeClockContext context)
        {
             _context = context;
            if (_context.Employees.Count() == 0)
            {
                _context.Employees.Add(new Employee { FirstName = "Rylan", LastName = "Wassem" }); _context.SaveChanges();
            }
            _repository = repository;
            _mapper = mapper;
        }

        [HttpGet]
        public ActionResult<IEnumerable<Employee>> GetAllEmployees()
        {
            var employeeItems = _repository.GetEmployees();

            return Ok(_mapper.Map<IEnumerable<EmployeeReadDto>>(employeeItems));
        }

        [HttpGet("{id}", Name="GetEmployeeById")]
        public ActionResult<EmployeeReadDto> GetEmployeeById(int Id)
        {
            var employeeItem = _repository.GetEmployeeById(Id);
            if(employeeItem != null)
            {
                return Ok(_mapper.Map<EmployeeReadDto>(employeeItem));
            }
            return NotFound();        
        }

        //POST api/employees
        [HttpPost]
        public ActionResult<EmployeeReadDto> CreateEmployee(EmployeeCreateDto employeeCreateDto)
        {
            var employeeModel = _mapper.Map<Employee>(employeeCreateDto);
            _repository.CreateEmployee(employeeModel);
            _repository.SaveChanges();

            var employeeReadDto = _mapper.Map<EmployeeReadDto>(employeeModel);

            //return Ok(employeeReadDto);
            return CreatedAtRoute(nameof(GetEmployeeById), new {Id = employeeReadDto.Id}, employeeReadDto);
        }
    }
}