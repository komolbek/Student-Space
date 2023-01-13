using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Student_plus.DomainModels
{
    [Table("MEETING_ATTENDEE")]
    public class MeetingAttendee
	{
        [Key]
        [Column("m_attendee_id")]
        public string MAttendeeId { get; set; }

        [ForeignKey("meeting_id")]
        [Column("meeting_id")]
        public string MeetingId { get; set; }

        [Column("attendee_number")]
        public string AttendeeNumber { get; set; }

        public MeetingAttendee(string mAttendeeId, string meetingId, string attendeeNumber)
        {
            MAttendeeId = mAttendeeId;
            MeetingId = meetingId;
            AttendeeNumber = attendeeNumber;
        }
    }
}

