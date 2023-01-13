using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using StudentPlus.Interfaces;

namespace StudentPlus.DomainModels
{
    [Table("SUPERVISOR")]
    public class Supervisor : IUser
    {
        [Key]
        [Column("supervisor_id")]
        public string SupervisorId { get; set; }

        [Column("supervisor_number")]
        public string SupervisorNumber { get; set; }

        [Column("first_name")]
        public string FirstName { get; set; }

        [Column("last_name")]
        public string LastName { get; set; }

        [Column("department")]
        public string Department { get; set; }

        [Column("title")]
        public string Title { get; set; }

        [Column("password")]
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

