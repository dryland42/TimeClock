using AutoMapper;
using TimeClock.Dtos;
using TimeClock.Models;

namespace TimeClock.Profiles
{
    public class EmployeesProfile : Profile
    {
        public EmployeesProfile()
        {
            CreateMap<Employee, EmployeeReadDto>();
        }
    }
}