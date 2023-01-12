using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using StudentPlus.Interfaces;

namespace StudentPlus.DomainModels
{
    public class Supervisor : IUser
    {
        [Key]
        public string SupervisorId { get; set; }

        public string SupervisorNumber { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Department { get; set; }
        public string Title { get; set; }
        public string Password { get; set; }

        public Supervisor(
            string supervisorId,
            string supervisorNumber,
            string firstName,
            string lastName,
            string department,
            string title,
            string password)
        {
            SupervisorId = supervisorId;
            SupervisorNumber = supervisorNumber;
            FirstName = firstName;
            LastName = lastName;
            Department = department;
            Title = title;
            Password = password;
        }
    }
}

