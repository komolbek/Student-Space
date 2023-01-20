using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StudentPlus.DomainModels
{
    [Table("SUPERVISEE")]
    public class Supervisee
    {
        [Key]
        [Column("supervisee_id")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public string SuperviseeId { get; set; }

        [Column("student_number")]
        [ForeignKey("student_number")]
        public string StudentNumber { get; set; }

        [Column("supervisor_id")]
        [ForeignKey("supervisor_id")]
        public string SupervisorId { get; set; }

        public Supervisee(string studentNumber, string supervisorId)
        {
            SuperviseeId = Guid.NewGuid().ToString();
            StudentNumber = studentNumber;
            SupervisorId = supervisorId;
        }
    }
}

