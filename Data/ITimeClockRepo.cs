using System.Collections.Generic;
using TimeClock.Models;

namespace TimeClock.Data 
{
    public interface ITimeClockRepo
    {
        bool SaveChanges();
        IEnumerable<Employee> GetEmployees();
        Employee GetEmployeeById(int Id);
        void CreateEmployee(Employee emp);
    }
}