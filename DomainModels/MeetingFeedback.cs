using System;
namespace Student_plus.DomainModels
{
	public class MeetingFeedback
	{
        public string MFeedbackId { get; set; }
        public string MeetingId { get; set; }
        public string StudentNumber { get; set; }
        public string Date { get; set; }
        public string FeedbackText { get; set; }
        public string Category { get; set; }
        public string Status { get; set; }
        public int Rating { get; set; }

        public MeetingFeedback(string mFeedbackId, string meetingId, string studentNumber, string date, string feedbackText, string category, string status, int rating)
        {
            MFeedbackId = mFeedbackId;
            MeetingId = meetingId;
            StudentNumber = studentNumber;
            Date = date;
            FeedbackText = feedbackText;
            Category = category;
            Status = status;
            Rating = rating;
        }
    }
}

