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
        public DbSet<Draft> Draft { get; set; }
        public DbSet<DraftFeedback> DraftFeedback { get; set; }
        public DbSet<Meeting> Meeting { get; set; }
        public DbSet<MeetingAttendee> MeetingAttendee { get; set; }
        public DbSet<MeetingFeedback> MeetingFeedback { get; set; }
        public DbSet<MeetingFeedbackCatergory> MeetingFeedbackCatergory { get; set; }
        public DbSet<MeetingFeedbackResponse> MeetingFeedbackResponse { get; set; }
        public DbSet<MeetingQA> MeetingQA { get; set; }
        public DbSet<MeetingRecording> MeetingRecording { get; set; }
        public DbSet<MeetingRequest> MeetingRequest { get; set; }
        public DbSet<Student> Student { get; set; }
        public DbSet<Supervisee> Supervisee { get; set; }
        public DbSet<Supervisor> Supervisor { get; set; }
        public DbSet<Token> Token { get; set; }

        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {}
    }
}

