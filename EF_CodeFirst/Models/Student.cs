using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EF_CodeFirst.Models
{
    public class Student
    {
        [Key]
        public int StudentID { get; set; }
        [Required]
        [Column(TypeName = "nchar(50)")]
        public string StudentName { get; set; }
        [Required]
        public DateTime DateOfBirth { get; set; }
        public decimal? Height { get; set; }
        [Column(TypeName = "float")]
        public float? Weight { get; set; }
    }
}
