using System;
using Student_plus.Domain_models;
using Student_plus.Enums;

namespace Student_plus.Interfaces
{
    public interface IUserAccount
    {
        IUser RegisterNewAccount(IUser user);
        IUser UpdateAccountDetails(IUser user);

        IUser Login(string email, string password);
        bool DeleteAccount(string userId, UserType userType);
    }
}

