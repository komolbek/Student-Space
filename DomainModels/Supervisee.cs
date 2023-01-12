using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Student_plus.DomainModels
{
    public class Supervisee
    {
        [Key]
        public string SuperviseeId { get; set; }

        [ForeignKey("StudentId")]
        public string StudentId{ get; set; }

        [ForeignKey("SupervisorId")]
        public string SupervisorId { get; set; }

        public Supervisee(string superviseeId, string studentId, string supervisorId)
        {
            SuperviseeId = superviseeId;
            StudentId = studentId;
            SupervisorId = supervisorId;
        }
    }
}

