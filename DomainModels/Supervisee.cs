using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Student_plus.DomainModels
{
    [Table("SUPERVISEE")]
    public class Supervisee
    {
        [Key]
        [Column("supervisee_id")]
        public string SuperviseeId { get; set; }

        [Column("student_id")]
        [ForeignKey("student_id")]
        public string StudentId { get; set; }

        [Column("supervisor_id")]
        [ForeignKey("supervisor_id")]
        public string SupervisorId { get; set; }

        public Supervisee(string superviseeId, string studentId, string supervisorId)
        {
            SuperviseeId = superviseeId;
            StudentId = studentId;
            SupervisorId = supervisorId;
        }
    }
}

