using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Student_plus.DomainModels
{
	public class Draft
	{
        [Key]
        public string DraftId { get; set; }

        [ForeignKey("StudentNumber")]
        public string StudentNumber { get; set; }
        
        [ForeignKey("SupervisorNumber")]
        public string SupervisorNumber { get; set; }
        public string FilePath { get; set; }
        public string Notes { get; set; }
        public string Status { get; set; }
        public string SubmittedDate { get; set; }

        public Draft(string draftId, string studentNumber, string supervisorNumber, string filePath, string notes, string status, string submittedDate)
        {
            DraftId = draftId;
            StudentNumber = studentNumber;
            SupervisorNumber = supervisorNumber;
            FilePath = filePath;
            Notes = notes;
            Status = status;
            SubmittedDate = submittedDate;
        }
    }
}

