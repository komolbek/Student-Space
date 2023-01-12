using System;
namespace Student_plus.DomainModels
{
	public class MeetingAttendee
	{
        public string MAttendeeId { get; set; }
        public string MeetingId { get; set; }
        public string AttendeeNumber { get; set; }

        public MeetingAttendee(string mAttendeeId, string meetingId, string attendeeNumber)
        {
            MAttendeeId = mAttendeeId;
            MeetingId = meetingId;
            AttendeeNumber = attendeeNumber;
        }
    }
}

