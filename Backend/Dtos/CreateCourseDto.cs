namespace UniversityAttendance.Dtos
{
    public class CreateCourseDto
    {
        public string CourseCode { get; set; } = null!;
        public string CourseName { get; set; } = null!;
        public int TeacherId { get; set; }
    }
}
