using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_Core_test.Model
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int? Age { get; set; }
        public int CardStudentId { get; set; }
        public CardStudent CardStudent { get; set; }
        public Department Department { get; set; }
        public int DepartmentId { get; set; }
        public List<StudentSubject> ListSubject { get; set; }

    }
}
