using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Student_plus.DomainModels
{
    [Table("DRAFT_FEEDBACK")]
    public class DraftFeedback
	{

        [Key]
        [Column("d_feedback_id")]
        public string DFeedbackId { get; set; }

        [ForeignKey("draft_id")]
        [Column("draft_id")]
        public string DraftId { get; set; }

        [Column("supervisor_num")]
        public string SupervisorNum { get; set; }

        [Column("d_feedback_text")]
        public string DFeedbackText { get; set; }

        [Column("d_response_date")]
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

