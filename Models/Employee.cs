using System.ComponentModel.DataAnnotations;

namespace TimeClock.Models 
{
    public class Employee 
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(25)]
        public string LastName { get; set; }
        
        [Required]
        [MaxLength(25)]
        public string FirstName { get; set; }
    }
}