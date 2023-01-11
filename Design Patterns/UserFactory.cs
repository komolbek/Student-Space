using System;
using Student_plus.Domain_models;

namespace Student_plus.Design_Patterns
{
	public class UserFactory
	{
		public static Student CreateStudent(Student studentDetails)
		{
			Student student = new Student(
				studentDetails.StudentId,
				studentDetails.SupervisorId,
				studentDetails.FirstName,
				studentDetails.LastName,
				studentDetails.Degree);

			return student;
        }
	}
}

