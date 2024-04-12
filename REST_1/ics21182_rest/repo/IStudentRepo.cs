using System.Collections.Generic;
using System.Linq;
using ics21182_rest.Models;

namespace ics21182_rest.repo
{
    public class IStudentRepo : IStudent
    {
        private readonly List<Student> _students = new List<Student>();

        public IEnumerable<Student> GetAllStudents()
        {
            return _students;
        }
        public Student GetStudent(string id)
        {
            return _students.FirstOrDefault(x => x.StudentID == id);
        }

        public void CreateStudent(Student student)
        {
            _students.Add(student);
        }
    }
}
