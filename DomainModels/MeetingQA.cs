using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Student_plus.DomainModels
{
    [Table("MEETING_QA")]
    public class MeetingQA
	{
        [Key]
        [Column("qa_id")]
        public string QaId { get; set; }

        [ForeignKey("meeting_id")]
        [Column("meeting_id")]
        public string MeetingId { get; set; }

        [Column("question")]
        public string Question { get; set; }

        [Column("speaker_name")]
        public string SpeakerName { get; set; }

        [Column("answer")]
        public string Answer { get; set; }

        [Column("timestamp")]
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

