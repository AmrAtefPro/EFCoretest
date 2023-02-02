using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_Core_test.Model
{
    public class Subject
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string desc { get; set; }
        public Subject() { }    

        public List<StudentSubject> ListStudents { get; set; }

    }
}
