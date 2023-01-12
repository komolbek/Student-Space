using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Student_plus.DomainModels
{
	public class MeetingFeedback
	{
        [Key]
        public string MFeedbackId { get; set; }

        [ForeignKey("MeetingId")]
        public string MeetingId { get; set; }

        [ForeignKey("StudentNumber")]
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

