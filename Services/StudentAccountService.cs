using System;
using Student_plus.Domain_models;
using Student_plus.Data_Repositories;
using Student_plus.Design_Patterns;

namespace Student_plus.Services
{
	public class StudentAccountService
	{

		private readonly StudentRepository _studentRepository;

        public StudentAccountService(
            StudentRepository studentRepository)
        {
            _studentRepository = studentRepository;
        }

        public Student RegisterNewStudent(Student newStudent)
		{
            Student student = (Student)_studentRepository.Save(newStudent);

            if (newStudent != null)
            {
                return newStudent;
            } else
            {
                throw new Exception("could not create new user");
            }
        }

        public Student UpdateStudentAccountDetails(Student student)
		{
            throw new NotImplementedException();
        }

        public Student LoginStudent(string email, string password)
		{
            throw new NotImplementedException();
        }

        public bool DeleteStudent(string studentId)
		{
            throw new NotImplementedException();
        }		
	}
}

