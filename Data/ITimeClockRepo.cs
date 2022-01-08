using System.Collections.Generic;
using TimeClock.Models;

namespace TimeClock.Data 
{
    public interface ITimeClockRepo
    {
        IEnumerable<Employee> GetEmployees();
        Employee GetEmployeeById(int Id);
    }
}