using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;
using StudentPlus.Interfaces;

namespace StudentPlus.DomainModels
{
    public class Student : IUser
    {
        public string StudentId { get; set; }
        public string StudentNumber { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Course { get; set; }
        public string GraduationDate { get; set; }
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

