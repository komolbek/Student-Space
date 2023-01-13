using System;
using StudentPlus.Enums;

namespace StudentPlus.DTOs
{
	public class LoginDTO
	{
        public UserType UserType { get; set; }
        public string UserNumber { get; set; }
        public string UserPassword { get; set; }

        public LoginDTO(string userNumber, string userPassword, UserType userType)
		{
            UserNumber = userNumber;
            UserPassword = userPassword;
            UserType = userType;
        }
	}
}

