using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Student_plus.DomainModels
{
	public class MeetingFeedbackResponse
	{
        [Key]
        public string FResponseId { get; set; }

        [ForeignKey("MeetingId")]
        public string MFeedbackId { get; set; }

        [ForeignKey("SupervisorId")]
        public string SupervisorId{ get; set; }

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

