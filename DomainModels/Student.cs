using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;
using StudentPlus.Interfaces;
using static Azure.Core.HttpHeader;

namespace StudentPlus.DomainModels
{
    [Table("STUDENT")]
    public class Student : IUser
    {
        [Key]
        [Column("student_id")]
        public string StudentId { get; set; }

        [Column("student_number")]
        public string StudentNumber { get; set; }

        [Column("first_name")]
        public string FirstName { get; set; }

        [Column("last_name")]
        public string LastName { get; set; }

        [Column("course")]
        public string Course { get; set; }

        [Column("graduation_date")]
        public string GraduationDate { get; set; }

        [Column("password")]
        public string Password { get; set; }

        public Student(
            string studentId,
            string studentNumber,
            string firstName,
            string lastName,
            string course,
            string graduationDate,
            string password)
        {
            StudentId = studentId;
            StudentNumber = studentNumber;
            FirstName = firstName;
            LastName = lastName;
            Course = course;
            GraduationDate = graduationDate;
            Password = password;
        }
    }
}

