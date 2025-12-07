using Microsoft.AspNetCore.Mvc;
using UniversityAttendance.Models;   // ← BURAYI AZ SONRA DÜZELTECEKSİN

namespace UniversityAttendance.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class TeachersController : ControllerBase
    {
        private readonly AppDbContext _context;

        public TeachersController(AppDbContext context)
        {
            _context = context;
        }

        // POST: /api/teachers
        [HttpPost]
        public async Task<IActionResult> Create([FromForm] Teacher teacher)
        {
            // TeacherId formdan gelmeyecek, DB identity veriyor.
            _context.Teachers.Add(teacher);
            await _context.SaveChangesAsync();

            return Ok(new { message = "Teacher created successfully" });
        }
    }
}
