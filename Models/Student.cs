using System.ComponentModel.DataAnnotations;

namespace WebApplication_Assign3_scaffolding.Models
{
    public class Student
    {
        [Required]
        public string? Name { get; set; }
        [Required]
        public int StudentId { get; set; }
        [Required]
        public int Age { get; set; }
        [Required]
        public int DOB { get; set; }
    }
}
