using System;
using StudentPlus.Enums;

namespace StudentPlus.DTOs
{
	public class LoginDTO
	{
        public UserType UserType { get; set; }
		public string UserId { get; set; }
        public string UserPassword { get; set; }

        public LoginDTO(UserType userType, string userId, string userPassword)
		{
			UserId = userId;
            UserType = userType;
			UserPassword = userPassword;

        }
	}
}

