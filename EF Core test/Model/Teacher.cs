using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_Core_test.Model
{
    public class Teacher
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<StudentSubject> ListSubject { get; set; }

    }
}
