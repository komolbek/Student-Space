using System;
using StudentPlus.DomainModels;
using StudentPlus.Enums;
using StudentPlus.Interfaces;
using StudentPlus.Services;

namespace StudentPlus.DesignPatterns
{
    public class UserAccountServiceAdapter : IUserAccount
    {
        private readonly StudentAccountService _studentAccountService;
        private readonly SupervisorAccountService _supervisorAccountService;

        public UserAccountServiceAdapter(
            StudentAccountService studentAccountService,
            SupervisorAccountService supervisorAccountService)
        {
            _studentAccountService = studentAccountService;
            _supervisorAccountService = supervisorAccountService;
        }

        public async Task<bool> DeleteAccountAsync(string userId, UserType userType)
        {
            if (userType == UserType.Student)
            {
                return await _studentAccountService.DeleteStudentAsync(userId);
            }
            else
            {
                return await _supervisorAccountService.DeleteSupervisorAsync(userId);
            }
        }

        public async Task<IUser> LoginAsync(string userNumber, string password, UserType userType)
        {
            if (userType == UserType.Student)
            {
                return await _studentAccountService.LoginStudentAsync(userNumber, password);
            }
            else 
            {
                return await _supervisorAccountService.LoginSupervisorAsync(userNumber, password);
            }
        }

        public async Task<IUser> RegisterNewAccountAsync(IUser user)
        {
            if (user is Student)
            {
                Student student = (Student)user;
                return await _studentAccountService.RegisterNewStudentAsync(student);
            }
            else
            {
                Supervisor supervisor = (Supervisor)user;
                return await _supervisorAccountService.RegisterNewSupervisorAsync(supervisor);
            }
        }

        public async Task<IUser> UpdateAccountDetailsAsync(IUser user, UserType userType)
        {
            if (user is Student)
            {
                Student student = (Student)user;
                return await _studentAccountService.UpdateStudentAccountAsync(student);
            }
            else
            {
                Supervisor supervisor = (Supervisor)user;
                return await _supervisorAccountService.UpdateSupervisorAccountAsync(supervisor);
            }
        }

        public async Task<Supervisor?> GetSupervisor(string studentNumber)
        {
            Supervisor? supervisor = await _supervisorAccountService.GetSupervisorByStudentNumber(studentNumber);

            if (supervisor == null)
            {
                return null;
            } else
            {
                return supervisor;
            }
        }
    }
}
