using System;
using StudentPlus.DomainModels;
using StudentPlus.DataRepositories;
using StudentPlus.DesignPatterns;

namespace StudentPlus.Services
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
            try
            {
                _studentRepository.Save(newStudent);
                return newStudent;
            } catch
            {
                throw;
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

        public Student DeleteStudent(string studentId)
		{
            return _studentRepository.GetStudentById(studentId);
        }		
	}
}

