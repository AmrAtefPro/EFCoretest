using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_Core_test.Model
{
    public class StudentSubject
    {
        public int Id { get; set; }

        public int StudentId { get; set; }
        public Student Student { get; set; }
        public int SubjectId { get; set; }
        public Subject Subject { get; set; }
        public Teacher Teacher { get; set; }
        public int TeacherId { get; set; }
    }
}
