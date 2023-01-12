using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Student_plus.DomainModels
{
	public class Meeting
	{
        [Key]
        public string MeetingId { get; set; }
        public string OrganiserId { get; set; }

        [ForeignKey("MRecordingId")]
        public string MRecordingId { get; set; }

        public string StartTime { get; set; }
        public string EndTime { get; set; }
        public string Topic { get; set; }
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

