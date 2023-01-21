using System;

namespace StudentPlus.DTOs
{
	public class SuperviseeDTO
	{        
        public string StudentNumber { get; set; }

        public SuperviseeDTO(string studentNumber)
        {
            StudentNumber = studentNumber;
        }
    }
}

