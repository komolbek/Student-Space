using System;
using StudentPlus.DomainModels;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using StudentPlus.Enums;
using System.IO;
using Student_plus.DomainModels;

namespace StudentPlus
{
    public class AppDbContext : DbContext
    {
        public DbSet<Draft> Drafts { get; set; }
        public DbSet<DraftFeedback> DraftFeedbacks { get; set; }
        public DbSet<Meeting> Meetings { get; set; }
        public DbSet<MeetingAttendee> MeetingAttendees { get; set; }
        public DbSet<MeetingFeedback> MeetingFeedbacks { get; set; }
        public DbSet<MeetingFeedbackCatergory> MeetingFeedbackCatergories { get; set; }
        public DbSet<MeetingFeedbackResponse> MeetingFeedbackResponses { get; set; }
        public DbSet<MeetingQA> MeetingQAs { get; set; }
        public DbSet<MeetingRecording> MeetingRecordings { get; set; }
        public DbSet<MeetingRequest> MeetingRequests { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<Supervisee> Supervisees { get; set; }
        public DbSet<Supervisor> Supervisors { get; set; }
        public DbSet<Token> Tokens { get; set; }

        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {}     
    }
}

