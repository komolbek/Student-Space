using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Student_plus.DomainModels
{
	public class DraftFeedback
	{
        [Key]
        public string DFeedbackId { get; set; }

        [ForeignKey("DraftId")]
        public string DraftId { get; set; }

        public string SupervisorNum { get; set; }
        public string DFeedbackText { get; set; }
        public string DResponseDate { get; set; }

        public DraftFeedback(string dFeedbackId, string draftId, string supervisorNum, string dFeedbackText, string dResponseDate)
        {
            DFeedbackId = dFeedbackId;
            DraftId = draftId;
            SupervisorNum = supervisorNum;
            DFeedbackText = dFeedbackText;
            DResponseDate = dResponseDate;
        }
    }
}

