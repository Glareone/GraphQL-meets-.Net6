using GraphQL.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace GraphQL.Data.Repository
{
    public class CoursesRepository
    {
        private readonly AppDbContext _context;
        public CoursesRepository(AppDbContext context)
        {
            _context = context;
        }

        public IEnumerable<Course> GetAllCourses()
        {
            return _context.Courses.Include(c => c.Reviews).ToList();
        }

        public Course? GetCourseById(int id)
        {
            return _context.Courses.FirstOrDefault(n => n.Id == id);
        }

        public Course AddCourse(Course course)
        {
            Course newCourse = new()
            {
                Name = course.Name,
                Description = course.Description,
                DateAdded = course.DateAdded,
                DateUpdated = course.DateUpdated,
            };
            
            _context.Courses.Add(newCourse);
            _context.SaveChanges();

            var reviews = course.Reviews.Select(r => new Review
            {
                Rate = r.Rate,
                Comment = r.Comment,
                CourseId = newCourse.Id
            }).ToList();
            
            _context.Reviews.AddRange(reviews);
            _context.SaveChanges();
            
            newCourse.Reviews = reviews;
            return newCourse;
        }

        public Course? UpdateCourse(int id, Course updatedCourse)
        {
            var course  = _context.Courses.FirstOrDefault(n => n.Id == id);

            if (course == null)
            {
                return null;
            }

            course.Name = updatedCourse.Name;
            course.Description = updatedCourse.Description;
            //course.Review = updatedCourse.Review;
            course.DateUpdated = DateTime.Now;
                
            _context.SaveChanges();
            return course;
        }

        public bool DeleteCourse(int id)
        {
            var course = _context.Courses.FirstOrDefault(n => n.Id == id);
            if (course == null)
            {
                return false;
            }
            
            _context.Courses.Remove(course);
            _context.SaveChanges();
            return true;
        }
    }
}
