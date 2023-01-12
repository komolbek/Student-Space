using System;
using System.ComponentModel.DataAnnotations;

namespace Student_plus.DomainModels
{
	public class MeetingRecording
	{
        [Key]
        public string RecordingId { get; set; }

        public string Title { get; set; }
        public string Duration { get; set; }
        public string Date { get; set; }
        public string VideoFilePath { get; set; }

        public MeetingRecording(string recordingId, string title, string duration, string date, string videoFilePath)
        {
            RecordingId = recordingId;
            Title = title;
            Duration = duration;
            Date = date;
            VideoFilePath = videoFilePath;
        }
    }
}

