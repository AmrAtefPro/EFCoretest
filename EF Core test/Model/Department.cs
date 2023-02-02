using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_Core_test.Model
{
    public class Department
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Name2 { get; set; }
        public string? Description { get; set; }
        public string Date { get; set; }
        public List<Student> Students { get; set; }

    }
}
