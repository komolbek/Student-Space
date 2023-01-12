using System;
using StudentPlus.DomainModels;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using StudentPlus.Enums;
using System.IO;

namespace StudentPlus
{
    public class AppDbContext : DbContext
    {
        public DbSet<Student> Students { get; set; }
        public DbSet<Supervisor> Supervisors { get; set; }

        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {}

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        => options.UseSqlite($"Data Source=mainDb.db");

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
           // modelBuilder.Entity<Student>()
           //.HasKey(s => s.StudentNumber);

           // modelBuilder.Entity<Student>()
           //     .HasIndex(s => s.SupervisorNumber)
           //     .IsUnique();

           // modelBuilder.Entity<Student>()
           //     .Property(s => s.StudentNumber)
           //     .IsRequired()
           //     .HasMaxLength(10);

           // modelBuilder.Entity<Student>()
           //     .Property(s => s.FirstName)
           //     .IsRequired();

           // modelBuilder.Entity<Student>()
           //     .Property(s => s.Password)
           //     .IsRequired();

           // modelBuilder.Entity<Supervisor>()
           //     .Property(s => s.SupervisorNumber)
           //     .IsRequired();

           // modelBuilder.Entity<Supervisor>()
           //     .Property(s => s.FirstName)
           //     .IsRequired();

           // modelBuilder.Entity<Supervisor>()
           //     .Property(s => s.Password)
           //     .IsRequired();

           // modelBuilder.Entity<Supervisor>()
           //     .Property(s => s.Department)
           //     .IsRequired();

           // modelBuilder.Entity<Supervisor>()
           //     .Property(s => s.Supervisees)
           //     .IsRequired();

           // modelBuilder.Entity<Supervisor>()
           //     .Property(s => s.Title)
           //     .IsRequired();
        }
    }
}

