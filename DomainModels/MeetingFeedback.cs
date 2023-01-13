using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Student_plus.DomainModels
{
    [Table("MEETING_FEEDBACK")]
    public class MeetingFeedback
	{
        [Key]
        [Column("m_feedback_id")]
        public string MFeedbackId { get; set; }

        [ForeignKey("meeting_id")]
        [Column("meeting_id")]
        public string MeetingId { get; set; }

        [ForeignKey("StudentNumber")]
        [Column("student_number")]
        public string StudentNumber { get; set; }

        [Column("date")]
        public string Date { get; set; }

        [Column("feedback_text")]
        public string FeedbackText { get; set; }

        [Column("category")]
        public string Category { get; set; }

        [Column("status")]
        public string Status { get; set; }

        [Column("rating")]
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

