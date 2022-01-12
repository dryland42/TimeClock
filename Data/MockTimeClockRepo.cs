using System.Collections.Generic;
using TimeClock.Models;

namespace TimeClock.Data
{
    public class MockTimeClockRepo : ITimeClockRepo
    {
        public void CreateEmployee(Employee emp)
        {
            throw new System.NotImplementedException();
        }

        public Employee GetEmployeeById(int Id)
        {
            return new Employee { Id=0, LastName="Stevens", FirstName="Bill" };
        }

        public IEnumerable<Employee> GetEmployees()
        {
            var Employees = new List<Employee> 
            {
                new Employee { Id=0, LastName="Stevens", FirstName="Bill" },
                new Employee { Id=1, LastName="Billington", FirstName="Steve" },
                new Employee { Id=2, LastName="Parsons", FirstName="Alan" }
            };

            return Employees;
        }

        public bool SaveChanges()
        {
            throw new System.NotImplementedException();
        }
    }
}