using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Text;
using System.Threading.Tasks;

namespace EF_Core_test.Model
{
    public class Department
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [StringLength(10)]
        public string Name { get; set; }
        [Required]
        [StringLength(10)]
        public string calss { get; set; }
        [Required]
        [StringLength(50)]
        public string? Description { get; set; }
        [StringLength(5)]
        public string? Period { get; set; } 
        public List<Student> Students { get; set; }

    }
}
it