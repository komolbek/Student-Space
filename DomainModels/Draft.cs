using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Student_plus.DomainModels
{
    [Table("DRAFT")]
    public class Draft
	{
        [Key]
        [Column("draft_id")]
        public string DraftId { get; set; }

        [ForeignKey("student_id")]
        [Column("student_id")]
        public string StudentId { get; set; }

        [ForeignKey("supervisor_id")]
        [Column("supervisor_id")]
        public string SupervisorId{ get; set; }

        [Column("file_path")]
        public string FilePath { get; set; }

        [Column("notes")]
        public string Notes { get; set; }

        [Column("status")]
        public string Status { get; set; }

        [Column("submitted_date")]
        public string SubmittedDate { get; set; }

        public Draft(string draftId, string studentId, string supervisorId, string filePath, string notes, string status, string submittedDate)
        {
            DraftId = draftId;
            StudentId = studentId;
            SupervisorId = supervisorId;
            FilePath = filePath;
            Notes = notes;
            Status = status;
            SubmittedDate = submittedDate;
        }
    }
}

