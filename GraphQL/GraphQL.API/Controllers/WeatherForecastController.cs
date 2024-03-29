using GraphQL.Data.Models;
using GraphQL.Data.Repository;
using Microsoft.AspNetCore.Mvc;

namespace GraphQL.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CoursesController : ControllerBase
    {
        private readonly CoursesRepository _coursesRepository;
        public CoursesController(CoursesRepository coursesRepository)
        {
            _coursesRepository = coursesRepository;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            var allCourses = _coursesRepository.GetAllCourses();
            return Ok(allCourses);
        }

        [HttpGet("{id}")]
        public IActionResult GetBookById(int id)
        {
            var book = _coursesRepository.GetCourseById(id);
            return Ok(book);
        }

        [HttpPost]
        public IActionResult AddBook([FromBody] Course course)
        {
            var addedCourse = _coursesRepository.AddCourse(course);
            return Ok(addedCourse);
        }

        [HttpPut("{id}")]
        public IActionResult Update(int id, [FromBody] Course course)
        {
            var updatedCourse = _coursesRepository.UpdateCourse(id, course);
            return Ok(updatedCourse);
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            _coursesRepository.DeleteCourse(id);
            return Ok();
        }
    }
}