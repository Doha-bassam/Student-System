using System.ComponentModel.DataAnnotations;
namespace WebApplication3.Models
{
    public class Student
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }
        public string Major { get; set; }
        public double GPA { get; set; }
    }
}
