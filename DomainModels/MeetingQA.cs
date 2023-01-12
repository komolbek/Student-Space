using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Student_plus.DomainModels
{
	public class MeetingQA
	{
        [Key]
        public string QaId { get; set; }

        [ForeignKey("MeetingId")]
        public string MeetingId { get; set; }

        public string Question { get; set; }
        public string SpeakerName { get; set; }
        public string Answer { get; set; }
        public string Timestamp { get; set; }

        public MeetingQA(string qaId, string meetingId, string question, string speakerName, string answer, string timestamp)
        {
            QaId = qaId;
            MeetingId = meetingId;
            Question = question;
            SpeakerName = speakerName;
            Answer = answer;
            Timestamp = timestamp;
        }        
    }
}

