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

        public bool DeleteAccount(string userId, UserType userType)
        {
            throw new NotImplementedException();             
        }

        public IUser Login(string email, string password)
        {
            return _studentAccountService.DeleteStudent(email);
        }

        public IUser RegisterNewAccount(IUser user)
        {
            if (user is Student)
            {
                Student student = (Student)user;
                return _studentAccountService.RegisterNewStudent(student);
            } else
            {
                throw new NotImplementedException();
            }
        }

        public IUser UpdateAccountDetails(IUser user)
        {
            throw new NotImplementedException();
        }
    }
}

