using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace UniversityAttendance.Models;

public partial class Classroom
{
    [Key]
    [Column("ClassroomID")]
    public int ClassroomId { get; set; }

    [StringLength(50)]
    public string Name { get; set; } = null!;

    [StringLength(100)]
    public string Location { get; set; } = null!;

    public int Capacity { get; set; }

    [InverseProperty("Classroom")]
    public virtual ICollection<AttendanceSession> AttendanceSessions { get; set; } = new List<AttendanceSession>();
}
