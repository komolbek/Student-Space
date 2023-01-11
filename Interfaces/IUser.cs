using System;
using System.ComponentModel.DataAnnotations;

namespace Student_plus.Interfaces
{
	public interface IUser
	{
        /// <summary>
        /// The first name of the user.
        /// </summary>
        [Required]
        public abstract string FirstName { get; set; }

        /// <summary>
        /// The last name of the user.
        /// </summary>
        public abstract string LastName { get; set; }

        /// <summary>
        /// The Password of the user.
        /// </summary>
        [Required]
        public abstract string Password { get; set; }
    }
}

