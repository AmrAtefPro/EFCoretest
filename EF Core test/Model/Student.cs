using System;
using System.Collections.Generic;
using System.ComponentModel;
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
        [Required(ErrorMessage = "{0} is required")]
        [StringLength(50, MinimumLength = 3,
        ErrorMessage = "First Name should be minimum 3 characters and a maximum of 50 characters")]
        [DataType(DataType.Text)]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "{0} is required")]
        [StringLength(50, MinimumLength = 3,
        ErrorMessage = "Last Name should be minimum 3 characters and a maximum of 50 characters")]
        [DataType(DataType.Text)]
        public string LastName { get; set; }

        [MaxLength(100)]
        public string? Description { get; set; }

        [DataType(DataType.Password)]
        [PasswordPropertyText]
        public string Password { get; set; }

        [Required]
        public int? Age { get; set; }

        [DataType(DataType.PhoneNumber)]
        [Phone]
        public int? Phonenum { get; set; }

        [DataType(DataType.EmailAddress)]
        [EmailAddress]
        public string Email{ get; set; }
        public CardStudent CardStudent { get; set; }
        public int CardStudentId { get; set; }
        public Department Department { get; set; }
        public int DepartmentId { get; set; }
        public List<StudentSubject> ListSubject { get; set; }

    }
}
