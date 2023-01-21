using System;
using StudentPlus.DataRepositories;
using StudentPlus.DomainModels;

namespace StudentPlus.Services
{
    public class SupervisorAccountService
    {

        private readonly SupervisorRepository _supervisorRepository;
        private readonly SuperviseeService _superviseeService;

        public SupervisorAccountService(
            SupervisorRepository supervisorRepository,
            SuperviseeService superviseeService)
        {
            _supervisorRepository = supervisorRepository;
            _superviseeService = superviseeService;
        }

        public async Task<Supervisor?> GetSupervisorByStudentNumber(string stdNumber)
        {
            string? supervisorId = await _superviseeService.GetSupervisorIdAsync(stdNumber);

            if (supervisorId != null)
            {
                return await _supervisorRepository.RetrieveByIdAsync(supervisorId);
            } else
            {
                return null;
            }           
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

