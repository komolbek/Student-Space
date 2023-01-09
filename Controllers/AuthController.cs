using System.ComponentModel;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Student_plus.Domain_models;

namespace Student_plus.Controllers
{
    /// <summary>
    /// Controller for handling user account related actions.
    /// </summary>
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        //private readonly IUserService _userService;

        /// <summary>
        /// Constructor for the UserController class.
        /// </summary>
        /// <param name="userService">Service for interacting with user data.</param>
        public AuthController()//IUserService userService)
        {
            //_userService = userService;
        }

        // Private fields for storing student and supervisor data

        // GET: api/Authorisation/Students
        /// <summary>
        /// Gets a list of all registered students.
        /// </summary>
        /// <returns>A list of students.</returns>
        [HttpGet]
        [Route("Students")]
        public async Task<ActionResult<IEnumerable<Student>>> GetStudents()
        {
            // Return list of students
            return new List<Student>();
        }

        // GET: api/Authorisation/Students/{id}
        /// <summary>
        /// Gets a specific student by their ID.
        /// </summary>
        /// <param name="id">The ID of the student to retrieve.</param>
        /// <returns>The student with the specified ID.</returns>
        [HttpGet]
        [Route("Students/{id}")]
        public async Task<ActionResult<Student>> GetStudent(int id)
        {
            // Return student with the specified ID
            return new Student(1,2,"");
        }

        // POST: api/Authorisation/Students
        /// <summary>
        /// Registers a new student.
        /// </summary>
        /// <param name="student">The student to register.</param>
        /// <returns>The registered student.</returns>
        [HttpPost]
        [Route("Students")]
        public async Task<ActionResult<Student>> RegisterStudent(Student student)
        {
            // Add student to database and return the registered student
            return new Student(1, 2, "");
        }

        // PUT: api/Authorisation/Students/{id}
        /// <summary>
        /// Updates a student's information.
        /// </summary>
        /// <param name="id">The ID of the student to update.</param>
        /// <param name="student">The updated student information.</param>
        /// <returns>The updated student.</returns>
        [HttpPut]
        [Route("Students/{id}")]
        public async Task<ActionResult<Student>> UpdateStudent(int id, Student student)
        {
            // Update student in the database and return the updated student
            return new Student(1, 2, "");
        }

        // DELETE: api/Authorisation/Students/{id}
        /// <summary>
        /// Deletes a student.
        /// </summary>
        /// <param name="id">The ID of the student to delete.</param>
        /// <returns>The deleted student.</returns>
        [HttpDelete]
        [Route("Students/{id}")]
        public async Task<ActionResult<Student>> DeleteStudent(int id)
        {
            // Delete student from the database and return the deleted student
            return new Student(1, 2, "");
        }

        // GET: api/Authorisation/Supervisors
        /// <summary>
        /// Gets a list of all registered supervisors.
        /// </summary>
        /// <returns>A list of supervisors.</returns>
        [HttpGet]
        [Route("Supervisors")]
        public async Task<ActionResult<IEnumerable<Supervisor>>> GetSupervisors()
        {
            // Return list of supervisors
            return new List<Supervisor>();
        }

        // GET: api/Authorisation/Supervisors/{id}
        /// <summary>
        /// Gets a specific supervisor by their ID.
        /// </summary>
        /// <param name="id">The ID of the supervisor to retrieve.</param>
        /// <returns>The supervisor with the specified ID.</returns>
        [HttpGet]
        [Route("Supervisors/{id}")]
        public async Task<ActionResult<Supervisor>> GetSupervisor(int id)
        {
            // Return supervisor with the specified ID
            return new Supervisor(2, "", "", "", "", "");
        }

        // POST: api/Authorisation/Supervisors
        /// <summary>
        /// Registers a new supervisor.
        /// </summary>
        /// <param name="supervisor">The supervisor to register.</param>
        /// <returns>The registered supervisor.</returns>
        [HttpPost]
        [Route("Supervisors")]
        public async Task<ActionResult<Supervisor>> RegisterSupervisor(Supervisor supervisor)
        {
            // Add supervisor to database and return the registered supervisor
            return new Supervisor(2, "", "", "", "", "");
        }

        // PUT: api/Authorisation/Supervisors/{id}
        /// <summary>
        /// Updates a supervisor's information.
        /// </summary>
        /// <param name="id">The ID of the supervisor to update.</param>
        /// <param name="supervisor">The updated supervisor information.</param>
        /// <returns>The updated supervisor.</returns>
        [HttpPut]
        [Route("Supervisors/{id}")]
        public async Task<ActionResult<Supervisor>> UpdateSupervisor(int id, Supervisor supervisor)
        {
            // Update supervisor in the database and return the updated supervisor
            return new Supervisor(2, "", "", "", "", "");
        }

        // DELETE: api/Authorisation/Supervisors/{id}
        /// <summary>
        /// Deletes a supervisor.
        /// </summary>
        /// <param name="id">The ID of the supervisor to delete.</param>
        /// <returns>The deleted supervisor.</returns>
        [HttpDelete]
        [Route("Supervisors/{id}")]
        public async Task<ActionResult<Supervisor>> DeleteSupervisor(int id)
        {
            // Delete supervisor from the database and return the deleted supervisor
            return new Supervisor(2, "", "", "", "", "");
        }

        // POST: api/Authorisation/Login
        /// <summary>
        /// Logs in a student or supervisor.
        /// </summary>
        /// <param name="login">The login information for the student or supervisor.</param>
        /// <returns>The logged in student or supervisor.</returns>
        //[HttpPost]
        //[Route("Login")]
        //public async Task<ActionResult<Student>> Login(LoginDTO login)
        //{
        //    // Validate login credentials and return the logged in student or supervisor
            
        //}
    }
}

