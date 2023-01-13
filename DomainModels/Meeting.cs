using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Student_plus.DomainModels
{
    [Table("MEETING")]
    public class Meeting
	{
        [Key]
        [Column("meeting_id")]
        public string MeetingId { get; set; }

        [Column("organiser_id")]
        public string OrganiserId { get; set; }

        [ForeignKey("m_recording_id")]
        [Column("m_recording_id")]
        public string MRecordingId { get; set; }

        [Column("start_time")]
        public string StartTime { get; set; }

        [Column("end_time")]
        public string EndTime { get; set; }

        [Column("topic")]
        public string Topic { get; set; }

        [Column("transcript")]
        public string Transcript { get; set; }

        public Meeting(string meetingId, string organiserId, string mRecordingId, string startTime, string endTime, string topic, string transcript)
        {
            MeetingId = meetingId;
            OrganiserId = organiserId;
            MRecordingId = mRecordingId;
            StartTime = startTime;
            EndTime = endTime;
            Topic = topic;
            Transcript = transcript;
        }
    }
}

