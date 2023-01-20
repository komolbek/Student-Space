using System;
using StudentPlus.DataRepositories;
using StudentPlus.DomainModels;

namespace StudentPlus.Services
{
    public class SupervisorAccountService
    {

        private readonly SupervisorRepository _supervisorRepository;

        public SupervisorAccountService(
            SupervisorRepository supervisorRepository)
        {
            _supervisorRepository = supervisorRepository;
        }

        public async Task<Supervisor> GetSupervisorByStudentId(string stdId)
        {
            return await _supervisorRepository.RetrieveByStudentIdAsync(stdId);
        }

        public async Task<Supervisor> RegisterNewSupervisorAsync(Supervisor newSupervisor)
        {
            try
            {
                await _supervisorRepository.InsertAsync(newSupervisor);
                return newSupervisor;
            }
            catch
            {
                throw;
            }
        }
        // todo: add logic for combining with token etc.
        public async Task<Supervisor> LoginSupervisorAsync(string supervisorNum, string password)
        {
            Supervisor supervisor = await _supervisorRepository.RetrieveAsync(supervisorNum, password);

            return supervisor;
        }

        public async Task<Supervisor> UpdateSupervisorAccountAsync(Supervisor supervisor)
        {
            return await _supervisorRepository.UpdateAsync(supervisor);
        }

        public async Task<bool> DeleteSupervisorAsync(string supervisorId)
        {
            return await _supervisorRepository.DeleteAsync(supervisorId);
        }
    }
}

