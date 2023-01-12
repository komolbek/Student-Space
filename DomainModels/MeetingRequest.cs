using System;
namespace Student_plus.DomainModels
{
	public class MeetingRequest
	{
        public string RequestId { get; set; }
        public string Organiser { get; set; }
        public string Topic { get; set; }
        public string Status { get; set; }
        public string CreatedDate { get; set; }
        public string DecisionDate { get; set; }
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

