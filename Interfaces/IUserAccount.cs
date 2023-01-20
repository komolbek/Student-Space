using System;
using StudentPlus.DomainModels;
using StudentPlus.Enums;

namespace StudentPlus.Interfaces
{
    public interface IUserAccount
    {
        /// <summary>
        /// creates new student/supervisor object in the db and returns to client
        /// </summary>
        public Task<IUser> RegisterNewAccountAsync(IUser user);

        // 
        /// <summary>
        /// updates existing student/supervisor object in the db and returns to client
        /// </summary>
        /// <returns>return notFound if not found</returns>
        public Task<IUser> UpdateAccountDetailsAsync(IUser user, UserType userType);

        /// <summary>
        /// authenticates or signs in existing user, by userName and password
        /// </summary>
        public Task<IUser> LoginAsync(string userNumber, string password, UserType userType);

        ///  <summary>
        /// deletes user
        /// </summary>
        public Task<bool> DeleteAccountAsync(string userId, UserType userType);

        ///  <summary>
        /// gets supervisor obejct by student id
        /// </summary>
        public Task<Supervisor> GetSupervisor(string studentId);
    }
}

