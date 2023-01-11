using System;
using Student_plus.Domain_models;
using Student_plus.Enums;
using Student_plus.Interfaces;
using Student_plus.Services;

namespace Student_plus.Design_Patterns
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
            if (userType == UserType.Student)
            {
                return _studentAccountService.DeleteStudent(userId);
            } else
            {
                return _supervisorAccountService.DeleteSupervisor(userId);
            }                
        }

        public IUser Login(string email, string password)
        {
            throw new NotImplementedException();
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

