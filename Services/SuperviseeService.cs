using System;
using Student_plus.DataRepositories;
using StudentPlus.DomainModels;

namespace Student_plus.Services
{
	public class SuperviseeService
	{

        private SuperviseeRepository _superviseeRepository;

		public SuperviseeService(SuperviseeRepository superviseeRepository)
		{
            _superviseeRepository = superviseeRepository;
		}

        public async Task<List<Student>> AssignStudentsToSupervisorAsync(List<Student> students, string supervisorId)
        {
            foreach (Student student in students)
            {
                string studentId = student.StudentId;
                Supervisee supervisee = new Supervisee(studentId, supervisorId);

                try
                {
                    await _superviseeRepository.AddSuperviseeAsync(supervisee);
                }
                catch
                {
                    throw;
                }
            }

            return students;
        }

        public async Task<Student> AssignStudentToSupervisorAsync(Student student, string supervisorId)
        {
            string studentId = student.StudentId;
            Supervisee supervisee = new Supervisee(studentId, supervisorId);

            try
            {
                await _superviseeRepository.AddSuperviseeAsync(supervisee);
            }
            catch
            {
                throw;
            }

            return student;
        }

        public async Task<string?> GetSupervisorIdAsync(string studentId)
        {
            Supervisee supervisee = await _superviseeRepository.GetSuperviseeByStudentIdAsync(studentId);
            if (supervisee == null)
            {
                return null;
            }
            else
            {
                string supervisorId = supervisee.SuperviseeId;
                return supervisorId;
            }
        }
    }
}

