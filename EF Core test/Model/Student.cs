using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_Core_test.Model
{
    public class Student
    {
        [Key]
        public int Id { get; set; }
        [Required,MaxLength(255)]
        public string Name { get; set; }
        [MaxLength(100)]
        public string? Description { get; set; }
        public int? Age { get; set; }
        public int? Phonenum { get; set; }
        public int CardStudentId { get; set; }
        public CardStudent CardStudent { get; set; }
        public Department Department { get; set; }
        public int DepartmentId { get; set; }
        public List<StudentSubject> ListSubject { get; set; }

    }
}
