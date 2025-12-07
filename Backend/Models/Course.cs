using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace UniversityAttendance.Models;

[Index("CourseCode", Name = "UQ__Courses__FC00E0004F92253B", IsUnique = true)]
public partial class Course
{
    [Key]
    [Column("CourseID")]
    public int CourseId { get; set; }

    [StringLength(20)]
    public string CourseCode { get; set; } = null!;

    [StringLength(100)]
    public string CourseName { get; set; } = null!;

    [Column("TeacherID")]
    public int TeacherId { get; set; }

    [InverseProperty("Course")]
    public virtual ICollection<AttendanceSession> AttendanceSessions { get; set; } = new List<AttendanceSession>();

    [InverseProperty("Course")]
    public virtual ICollection<Enrollment> Enrollments { get; set; } = new List<Enrollment>();

    [ForeignKey("TeacherId")]
    [InverseProperty("Courses")]
    public virtual Teacher Teacher { get; set; }
}
