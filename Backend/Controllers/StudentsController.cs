using Microsoft.AspNetCore.Mvc;
using UniversityAttendance.Models;

namespace UniversityAttendance.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class StudentsController : ControllerBase
    {
        private readonly AppDbContext _context;

        public StudentsController(AppDbContext context)
        {
            _context = context;
        }

        // POST: /api/students
        [HttpPost]
        public async Task<IActionResult> Create([FromForm] Student student)
        {
            _context.Students.Add(student);
            await _context.SaveChangesAsync();

            return Ok(new { message = "Student created successfully" });
        }
    }
}
