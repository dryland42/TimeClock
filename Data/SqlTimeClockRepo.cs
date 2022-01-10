using System;
using System.Collections.Generic;
using System.Linq;
using TimeClock.Models;

namespace TimeClock.Data 
{
    public class SqlTimeClockRepo : ITimeClockRepo
    {
        private readonly TimeClockContext _context;

        public SqlTimeClockRepo(TimeClockContext context)
        {
            _context = context;
        }
        public Employee GetEmployeeById(int id)
        {
            return _context.Employees.FirstOrDefault(x => x.Id == id);
        }

        public IEnumerable<Employee> GetEmployees()
        {
            return _context.Employees.ToList();
        }
    }
}