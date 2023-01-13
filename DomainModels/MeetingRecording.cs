using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Student_plus.DomainModels
{
    [Table("MEETING_RECORDING")]
    public class MeetingRecording
	{
        [Key]
        [Column("recording_id")]
        public string RecordingId { get; set; }

        [Column("title")]
        public string Title { get; set; }

        [Column("duration")]
        public string Duration { get; set; }

        [Column("date")]
        public string Date { get; set; }

        [Column("video_file_path")]
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

