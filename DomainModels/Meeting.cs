using System;
namespace Student_plus.DomainModels
{
	public class Meeting
	{
        public string MeetingId { get; set; }
        public string OrganiserId { get; set; }
        public string MRecordingId { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public string Topic { get; set; }
        public string Transcript { get; set; }

        public Meeting(string meetingId, string organiserId, string mRecordingId, DateTime startTime, DateTime endTime, string topic, string transcript)
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

