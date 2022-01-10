using Microsoft.EntityFrameworkCore;
using TimeClock.Models;

namespace TimeClock.Data
{
    public class TimeClockContext : DbContext 
    {
        public TimeClockContext(DbContextOptions<TimeClockContext> options) : base(options)
        {
            
        }

        public DbSet<Employee> Employees { get; set; }
    }
}