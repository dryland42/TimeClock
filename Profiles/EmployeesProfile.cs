using AutoMapper;
using TimeClock.Dtos;
using TimeClock.Models;

namespace TimeClock.Profiles
{
    public class EmployeesProfile : Profile
    {
        public EmployeesProfile()
        {
            //Source -> Target
            CreateMap<Employee, EmployeeReadDto>();
            CreateMap<EmployeeCreateDto, Employee>();
        }
    }
}