using System;
namespace Student_plus.DomainModels
{
	public class MeetingRecording
	{
        public string RecordingId { get; set; }
        public string Title { get; set; }
        public string Duration { get; set; }
        public DateTime Date { get; set; }
        public string VideoFilePath { get; set; }

        public MeetingRecording(string recordingId, string title, string duration, DateTime date, string videoFilePath)
        {
            RecordingId = recordingId;
            Title = title;
            Duration = duration;
            Date = date;
            VideoFilePath = videoFilePath;
        }
    }
}

