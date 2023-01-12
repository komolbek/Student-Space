using System;
namespace Student_plus.DomainModels
{
    public class Supervisee
    {
        public string SuperviseeId { get; set; }
        public string StudentNumber { get; set; }
        public string SupervisorNumber { get; set; }

        public Supervisee(string superviseeId, string studentNumber, string supervisorNumber)
        {
            SuperviseeId = superviseeId;
            StudentNumber = studentNumber;
            SupervisorNumber = supervisorNumber;
        }
    }
}

