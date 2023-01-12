using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;
using StudentPlus.Interfaces;

namespace StudentPlus.DomainModels
{
    public class Student : IUser
    {
        public string StudentNumber { get; set; }
        public string SupervisorNumber { get; set; }        
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Password { get; set; }
        public string Degree { get; set; }

        public Student(
            string studentNumber,
            string supervisorNumber,
            string firstName,            
            string password,
            string lastName = "",
            string degree = "")
        {
            StudentNumber = studentNumber;
            SupervisorNumber = supervisorNumber;            
            FirstName = firstName;
            LastName = lastName;
            Degree = degree;
            Password = password;
        }                              
    }
}

