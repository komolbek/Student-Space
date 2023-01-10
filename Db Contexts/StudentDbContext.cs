using System;
using Student_plus.Domain_models;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using Student_plus.Enums;

namespace Student_plus.Db_Contexts
{
    public class StudentDbContext : DbContext
    {
        public StudentDbContext(DbContextOptions<StudentDbContext> options)
            : base(options)
        { }

        public DbSet<Student> Students { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Student>().ToTable(DbTableNames.Student.ToString());
        }

        /// <summary>
        /// Adds a new student to the database.
        /// </summary>
        /// <param name="student">The student to add.</param>
        public void AddStudent(Student student)
        {
            Students.Add(student);
            SaveChanges();
        }

        /// <summary>
        /// Gets a student by their StudentId.
        /// </summary>
        /// <param name="studentId">The StudentId of the student to retrieve.</param>
        /// <returns>The student with the matching StudentId, or null if no matching student is found.</returns>
        public Student GetStudentById(int studentId)
        {
            return Students.FirstOrDefault(s => s.StudentId == studentId);
        }

        /// <summary>
        /// Gets all students supervised by a specific supervisor.
        /// </summary>
        /// <param name="supervisorId">The SupervisorId of the supervisor.</param>
        /// <returns>A list of students supervised by the specified supervisor.</returns>
        public List<Student> GetStudentsBySupervisor(int supervisorId)
        {
            return Students.Where(s => s.SupervisorId == supervisorId).ToList();
        }

        /// <summary>
        /// Updates an existing student in the database.
        /// </summary>
        /// <param name="student">The updated student information.</param>
        public void UpdateStudent(Student student)
        {
            Students.Update(student);
            SaveChanges();
        }

        /// <summary>
        /// Deletes a student from the database.
        /// </summary>
        /// <param name="student">The student to delete.</param>
        public void DeleteStudent(Student student)
        {
            Students.Remove(student);
            SaveChanges();
        }
    }
}

