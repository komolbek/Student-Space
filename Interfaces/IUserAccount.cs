using System;
using StudentPlus.DomainModels;
using StudentPlus.Enums;

namespace StudentPlus.Interfaces
{
    public interface IUserAccount
    {
        public Task<IUser> RegisterNewAccountAsync(IUser user);
        public Task<IUser> UpdateAccountDetailsAsync(IUser user, UserType userType);

        public Task<IUser> LoginAsync(string userNumber, string password, UserType userType);
        public Task<bool> DeleteAccountAsync(string userId, UserType userType);
    }
}

