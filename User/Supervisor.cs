using System;
namespace Student_plus.User
{
    /// <summary>
    /// Supervisor class responsible for creating, authenticating, updating, reviewing meeting requests,
    /// providing meeting feedback responses, and reviewing drafts from students.
    /// </summary>
    public class Supervisor
    {
        /// <summary>
    /// Creates a new supervisor with the given username, password, and name, returns true if successful, false otherwise.
    /// </summary>
    /// <param name="username">The username of the supervisor.</param>
    /// <param name="password">The password of the supervisor.</param>
    /// <param name="name">The name of the supervisor.</param>
    /// <returns>True if successful, false otherwise.</returns>
    public bool CreateSupervisor(string username, string password, string name)
    {
        return false;
    }

    /// <summary>
    /// Updates the supervisor with the given username and password with the new username, password, and name, returns true if successful, false otherwise.
    /// </summary>
    /// <param name="username">The username of the supervisor.</param>
    /// <param name="password">The password of the supervisor.</param>
    /// <param name="newUsername">The new username of the supervisor.</param>
    /// <param name="newPassword">The new password of the supervisor.</param>
    /// <param name="newName">The new name of the supervisor.</param>
    /// <returns>True if successful, false otherwise.</returns>
    public bool UpdateSupervisor(string username, string password, string newUsername, string newPassword, string newName)
    {
        return false;
    }

    /// <summary>
    /// Returns a list of all the meeting requests for the supervisor.
    /// </summary>
    /// <returns>A list of all the meeting requests for the supervisor.</returns>
    //public List<MeetingRequest> ReviewMeetingRequests()
    //{
    //    return null;
    //}

    /// <summary>
    /// Provides the given feedback in response to the student with the given studentUsername's meeting on the given meetingDate, returns true if successful, false otherwise.
    /// </summary>
    /// <param name="studentUsername">The username of the student.</param>
    /// <param name="meetingDate">The date of the meeting.</param>
    /// <param name="feedback">The feedback to be given.</param>
    /// <returns>True if successful, false otherwise.</returns>
    public bool ProvideMeetingFeedbackResponse(string studentUsername, DateTime meetingDate, string feedback)
    {
        return false;
    }

    /// <summary>
    /// Reviews the given draft from the student with the given studentUsername and provides the given feedback, returns true if successful, false otherwise.
    /// </summary>
    /// <param name="studentUsername">The username of the student.</param>
    /// <param name="draft">The draft to be reviewed.</param>
    /// <param name="feedback">The feedback to be given.</param>
    /// <returns>True if successful, false otherwise.</returns>
    public bool ReviewDraft(string studentUsername, string draft, string feedback)
    {
        return false;
    }
    }
}

