using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace UniversityAttendance.Models;

public partial class Enrollment
{
    [Key]
    [Column("EnrollmentsID")]
    public int EnrollmentsId { get; set; }

    [Column("StudentID")]
    public int StudentId { get; set; }

    [Column("CourseID")]
    public int CourseId { get; set; }

    public DateOnly EnrollmentDate { get; set; }

    [ForeignKey("CourseId")]
    [InverseProperty("Enrollments")]
    public virtual Course Course { get; set; } = null!;

    [ForeignKey("StudentId")]
    [InverseProperty("Enrollments")]
    public virtual Student Student { get; set; } = null!;
}
