using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Text;
using System.Threading.Tasks;

namespace EF_Core_test.Model
{
    public class Teacher
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [StringLength(20)]
        public string Name { get; set; }
        [DataType(DataType.Date)]
        public int? Age { get; set; }
        [Required]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        [DataType(DataType.Password)]
        public string password { get; set; }
        public List<StudentSubject> ListSubject { get; set; }

    }
}
