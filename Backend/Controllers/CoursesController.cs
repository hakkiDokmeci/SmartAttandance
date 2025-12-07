using Microsoft.AspNetCore.Mvc;
using UniversityAttendance.Models;
using UniversityAttendance.Dtos; 


namespace UniversityAttendance.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CoursesController : ControllerBase
    {
        private readonly AppDbContext _context;

        public CoursesController(AppDbContext context)
        {
            _context = context;
        }

        [HttpPost]
        public async Task<IActionResult> Create([FromForm] CreateCourseDto dto)
        {
            // HTML formundan sadece basit alanları alıyoruz
            // ve burada gerçek Course nesnesini kendimiz oluşturuyoruz.
            var course = new Course
            {
                CourseCode = dto.CourseCode,
                CourseName = dto.CourseName,
                TeacherId = dto.TeacherId
            };

            _context.Courses.Add(course);
            await _context.SaveChangesAsync();

            return Ok(new { message = "Course created successfully" });
        }

    }
}
