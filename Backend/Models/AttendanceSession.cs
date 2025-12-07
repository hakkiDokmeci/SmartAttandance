using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace UniversityAttendance.Models;

[Table("Attendance_Sessions")]
public partial class AttendanceSession
{
    [Key]
    [Column("SessionID")]
    public int SessionId { get; set; }

    [Column("CourseID")]
    public int CourseId { get; set; }

    [Column("ClassroomID")]
    public int ClassroomId { get; set; }

    public DateTime SessionDateTime { get; set; }

    [InverseProperty("Session")]
    public virtual ICollection<AttendanceRecord> AttendanceRecords { get; set; } = new List<AttendanceRecord>();

    [ForeignKey("ClassroomId")]
    [InverseProperty("AttendanceSessions")]
    public virtual Classroom Classroom { get; set; } = null!;

    [ForeignKey("CourseId")]
    [InverseProperty("AttendanceSessions")]
    public virtual Course Course { get; set; } = null!;
}
