using System;
namespace Student_plus.DomainModels
{
	public class MeetingFeedbackResponse
	{
        public string FResponseId { get; set; }
        public string MFeedbackId { get; set; }
        public string SupervisorNumber { get; set; }
        public string ResponseText { get; set; }

        public MeetingFeedbackResponse(string fResponseId, string mFeedbackId, string supervisorNumber, string responseText)
        {
            FResponseId = fResponseId;
            MFeedbackId = mFeedbackId;
            SupervisorNumber = supervisorNumber;
            ResponseText = responseText;
        }
    }
}

