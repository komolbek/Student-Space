using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Student_plus.DomainModels
{
    [Table("MEETING_FEEDBACK_RESPONSE")]
	public class MeetingFeedbackResponse
	{
        [Key]
        [Column("f_response_id")]
        public string FResponseId { get; set; }

        [ForeignKey("meeting_id")]
        [Column("meeting_id")]
        public string MFeedbackId { get; set; }

        [ForeignKey("supervisor_id")]
        [Column("supervisor_id")]
        public string SupervisorId { get; set; }

        [Column("response_text")]
        public string ResponseText { get; set; }

        public MeetingFeedbackResponse(string fResponseId, string mFeedbackId, string supervisorId, string responseText)
        {
            FResponseId = fResponseId;
            MFeedbackId = mFeedbackId;
            SupervisorId = supervisorId;
            ResponseText = responseText;
        }
    }
}

