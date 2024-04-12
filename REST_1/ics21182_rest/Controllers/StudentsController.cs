using Microsoft.AspNetCore.Mvc;
using ics21182_rest.repo;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ics21182_rest.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentsController : ControllerBase
    {
        private readonly IStudent _repository;

        public StudentsController(IStudent repository)
        {
            _repository = repository;
        }

        [HttpGet]
        public IEnumerable<ics21182_rest.repo.IStudent> GetAllStudents()
        {
            return (IEnumerable<IStudent>)_repository.GetAllStudents();
        }

        [HttpGet("{id}")]
        public IActionResult GetStudent(string id)
        {
            var student = _repository.GetStudent(id);
            if (student == null)
            {
                return NotFound();
            }
            return Ok(student);
        }

        [HttpPost]
        public IActionResult CreateStudent(Models.Student student)
        {
            _repository.CreateStudent(student);
            return CreatedAtAction(nameof(GetStudent), new { id = student.StudentID }, student);
        }
    }
}