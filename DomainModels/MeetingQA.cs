using System;
namespace Student_plus.DomainModels
{
	public class MeetingQA
	{
        public string QaId { get; set; }
        public string MeetingId { get; set; }
        public string Question { get; set; }
        public string SpeakerName { get; set; }
        public string Answer { get; set; }
        public DateTime Timestamp { get; set; }

        public MeetingQA(string qaId, string meetingId, string question, string speakerName, string answer, DateTime timestamp)
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

