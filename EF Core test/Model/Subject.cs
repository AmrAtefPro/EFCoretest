using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Text;
using System.Threading.Tasks;

namespace EF_Core_test.Model
{
    public class Subject
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [StringLength(25)]
        public string Name { get; set; }
        [DataType(DataType.Text)]
        [MaxLength(100)]
        public string? Description { get; set; }
        [DataType(DataType.Date)]
        public int? Age { get; set; }

        
        public List<StudentSubject> ListStudents { get; set; }

    }
}
