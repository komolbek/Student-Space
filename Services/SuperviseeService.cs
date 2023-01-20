using System;
using Student_plus.DataRepositories;
using Student_plus.DTOs;
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

        public async Task<List<SuperviseeDTO>> AssignStudentsToSupervisorAsync(List<SuperviseeDTO> studentNumbers, string supervisorId)
        {
            foreach (SuperviseeDTO studentNumber in studentNumbers)
            {
                Supervisee supervisee = new Supervisee(studentNumber.StudentNumber, supervisorId);

                try
                {
                    await _superviseeRepository.AddSuperviseeAsync(supervisee);
                }
                catch
                {
                    throw;
                }
            }

            return studentNumbers;
        }

        public async Task<SuperviseeDTO> AssignStudentToSupervisorAsync(SuperviseeDTO studentNumber, string supervisorId)
        {
            Supervisee supervisee = new Supervisee(studentNumber.StudentNumber, supervisorId);

            try
            {
                await _superviseeRepository.AddSuperviseeAsync(supervisee);
            }
            catch
            {
                throw;
            }

            return studentNumber;
        }

        public async Task<string?> GetSupervisorIdAsync(string studentNumber)
        {
            Supervisee supervisee = await _superviseeRepository.GetSuperviseeByStudentNumberAsync(studentNumber);
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

