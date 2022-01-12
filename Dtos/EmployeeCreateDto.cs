using System.ComponentModel.DataAnnotations;

namespace TimeClock.Dtos
{
    public class EmployeeCreateDto
    {
        [Required]
        [MaxLength(25)]
        public string LastName { get; set; }
        
        [Required]
        [MaxLength(25)]
        public string FirstName { get; set; }
    }
}