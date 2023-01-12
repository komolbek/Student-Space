using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using StudentPlus.Interfaces;

namespace StudentPlus.DomainModels
{
    public class Supervisor : IUser
    {
        public string SupervisorNumber { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Password { get; set; }
        public string Department { get; set; }
        public string Supervisees { get; set; }
        public string Title { get; set; }


        public Supervisor(string supervisorNumber, string firstName, string lastName, string password, string department, string supervisees, string title)
        {
            SupervisorNumber = supervisorNumber;
            FirstName = firstName;
            LastName = lastName;
            Password = password;
            Department = department;
            Supervisees = supervisees;
            Title = title;
        }  
    }
}

