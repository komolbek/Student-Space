using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Student_plus.User
{
    public class Student
    {
        /// <summary>
        /// The unique identifier of the student.
        /// </summary>
        [Key]
        public int StudentId { get; set; }

        /// <summary>
        /// The unique identifier of the student's supervisor.
        /// </summary>
        [Required]
        public int SupervisorId { get; set; }

        /// <summary>
        /// The first name of the student.
        /// </summary>
        [Required]
        public string FirstName { get; set; }

        /// <summary>
        /// The last name of the student.
        /// </summary>
        public string LastName { get; set; }

        /// <summary>
        /// The degree that the student is pursuing.
        /// </summary>
        public string Degree { get; set; }

        public Student(int studentId, int supervisorId, string firstName, string lastName = "", string degree = "")
        {
            StudentId = studentId;
            SupervisorId = supervisorId;
            FirstName = firstName;
            LastName = lastName;
            Degree = degree;
        }


        /// <summary>
        /// Creates a new student with the given username, password, and name, returns true if successful, false otherwise.
        /// </summary>
        /// <param name="username">Username of the student.</param>
        /// <param name="password">Password of the student.</param>
        /// <param name="name">Name of the student.</param>
        /// <returns>Returns true if successful, false otherwise.</returns>
        public bool CreateStudent(string username, string password, string name)
        {
            return false;
        }

        /// <summary>
        /// Updates the student with the given username and password with the new username, password, and name, returns true if successful, false otherwise.
        /// </summary>
        /// <param name="username">Username of the student.</param>
        /// <param name="password">Password of the student.</param>
        /// <param name="newUsername">New username of the student.</param>
        /// <param name="newPassword">New password of the student.</param>
        /// <param name="newName">New name of the student.</param>
        /// <returns>Returns true if successful, false otherwise.</returns>
        public bool UpdateStudent(string username, string password, string newUsername, string newPassword, string newName)
        {
            return false;
        }

        /// <summary>
        /// Schedules a meeting with the supervisor with the given supervisorUsername on the given meetingDate and meetingTime, returns true if successful, false otherwise.
        /// </summary>
        /// <param name="supervisorUsername">Username of the supervisor.</param>
        /// <param name="meetingDate">Date of the meeting.</param>
        /// <param name="meetingTime">Time of the meeting.</param>
        /// <returns>Returns true if successful, false otherwise.</returns>
        public bool ScheduleMeeting(string supervisorUsername, DateTime meetingDate, TimeSpan meetingTime)
        {
            return false;
        }

        /// <summary>
        /// Submits the given feedback about their meeting with the supervisor with the given supervisorUsername on the given meetingDate, returns true if successful, false otherwise.
        /// </summary>
        /// <param name="supervisorUsername">Username of the supervisor.</param>
        /// <param name="meetingDate">Date of the meeting.</param>
        /// <param name="feedback">Feedback of the meeting.</param>
        /// <returns>Returns true if successful, false otherwise.</returns>
        public bool SubmitMeetingFeedback(string supervisorUsername, DateTime meetingDate, string feedback)
        {
            return false;
        }

        /// <summary>
        /// Returns a list of all the meeting feedback responses for the student.
        /// </summary>
        /// <returns>List of all the meeting feedback responses for the student.</returns>
        //public List<MeetingFeedbackResponse> ViewMeetingFeedbackResponses()
        //{
        //    return new List<MeetingFeedbackResponse>();
        //}

        /// <summary>
        /// Submits the given draft for feedback and review by the supervisor with the given supervisorUsername, returns true if successful, false otherwise.
        /// </summary>
        /// <param name="supervisorUsername">Username of the supervisor.</param>
        /// <param name="draft">Draft to be submitted.</param>
        /// <returns>Returns true if successful, false otherwise.</returns>
        public bool SubmitDraft(string supervisorUsername, string draft)
        {
            return false;
        }
    }
}

