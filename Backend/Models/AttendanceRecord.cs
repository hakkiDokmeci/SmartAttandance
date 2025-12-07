using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace UniversityAttendance.Models;

[Table("Attendance_Records")]
public partial class AttendanceRecord
{
    [Key]
    [Column("RecordID")]
    public int RecordId { get; set; }

    [Column("SessionID")]
    public int SessionId { get; set; }

    [Column("StudentID")]
    public int StudentId { get; set; }

    [StringLength(20)]
    public string Status { get; set; } = null!;

    [ForeignKey("SessionId")]
    [InverseProperty("AttendanceRecords")]
    public virtual AttendanceSession Session { get; set; } = null!;

    [ForeignKey("StudentId")]
    [InverseProperty("AttendanceRecords")]
    public virtual Student Student { get; set; } = null!;
}
