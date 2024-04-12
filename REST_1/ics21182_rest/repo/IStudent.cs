using ics21182_rest.Models;
using System.Collections.Generic;
namespace ics21182_rest.repo
{
    public interface IStudent
    {
        IEnumerable<Student> GetAllStudents();
        Student GetStudent(string id);
        void CreateStudent(Student student);
    }
}
