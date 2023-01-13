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
        public async Task<Student> RegisterNewStudentAsync(Student newStudent)
        {
            try
            {
                await _studentRepository.InsertAsync(newStudent);
                return newStudent;
            }
            catch
            {
                throw;
            }
        }
        // todo: add logic for combining with token etc.
        public async Task<Student> LoginStudentAsync(string studentNum, string password)
        {
            Student student = await _studentRepository.RetrieveAsync(studentNum, password);

            return student;
        }

        public async Task<Student> UpdateStudentAccountAsync(Student student)
        {
            return await _studentRepository.UpdateAsync(student);
        }

        public async Task<bool> DeleteStudentAsync(string studentId)
        {
            return await _studentRepository.DeleteAsync(studentId);
        }
    }
}

