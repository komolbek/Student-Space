using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Student_plus.DomainModels
{
	public class MeetingAttendee
	{
        [Key]
        public string MAttendeeId { get; set; }

        [ForeignKey("MeetingId")]
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

