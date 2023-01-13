using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Student_plus.DomainModels
{
    [Table("MEETING_REQUEST")]
    public class MeetingRequest
	{
        [Key]
        [Column("request_id")]
        public string RequestId { get; set; }

        [Column("organiser")]
        public string Organiser { get; set; }

        [Column("topic")]
        public string Topic { get; set; }

        [Column("status")]
        public string Status { get; set; }

        [Column("created_date")]
        public string CreatedDate { get; set; }

        [Column("decision_date")]
        public string DecisionDate { get; set; }

        [Column("notes")]
        public string Notes { get; set; }

        public MeetingRequest(string requestId, string organiser, string topic, string status, string createdDate, string decisionDate, string notes)
        {
            RequestId = requestId;
            Organiser = organiser;
            Topic = topic;
            Status = status;
            CreatedDate = createdDate;
            DecisionDate = decisionDate;
            Notes = notes;
        }
    }
}

