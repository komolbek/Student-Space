using System;
using StudentPlus.DomainModels;
using StudentPlus.Enums;

namespace StudentPlus.Interfaces
{
    public interface IUserAccount
    {
        IUser RegisterNewAccount(IUser user);
        IUser UpdateAccountDetails(IUser user);

        IUser Login(string email, string password);
        bool DeleteAccount(string userId, UserType userType);
    }
}

