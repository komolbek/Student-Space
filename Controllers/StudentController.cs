using System.ComponentModel;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Student_plus.Domain_models;
using Student_plus.User;
using Student_plus.DTOs;
using Student_plus.Interfaces;

namespace Student_plus.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        private readonly IUserAccount _userAccount;
       
        public StudentController(IUserAccount userAccount)
        {
            _userAccount = userAccount;
        }

        // Private fields for storing student and supervisor data

        // GET: api/Authorisation/Students
        [HttpGet]
        [Route("Students")]
        public async Task<ActionResult<IEnumerable<Student>>> Get()
        {
            // Return list of students
            return new List<Student>();
        }

        // GET: api/Authorisation/Students/{id}
        [HttpGet]
        [Route("Students/{id}")]
        public async Task<ActionResult<Student>> GetById(int id)
        {
            // Return student with the specified ID
            return new Student(1,2,"");
        }

        // POST: api/Authorisation/Students
        [HttpPost]
        [Route("Students")]
        public async Task<ActionResult<Student>> Register(Student student)
        {
            // Validate incoming student
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            // Add student to database
            var result = await Task.Run(() => this._userAccount.RegisterNewAccount(student));

            // Return the registered student
            if (result != null)
            {
                return CreatedAtAction(nameof(Register), result);
            }
            else
            {
                return BadRequest("Unable to register student");
            }
        }

        // PUT: api/Authorisation/Students/{id}
        [HttpPut]
        [Route("Students/{id}")]
        public async Task<ActionResult<Student>> Update(int id, Student student)
        {
            // Update student in the database and return the updated student
            return new Student(1, 2, "");
        }

        // DELETE: api/Authorisation/Students/{id}
        [HttpDelete]
        [Route("Students/{id}")]
        public async Task<ActionResult<Student>> Delete(int id)
        {
            return new EmptyResult();
        }

        

        // POST: api/Authorisation/Students/Login
        [HttpPost]
        [Route("Students/Login")]
        public async Task<ActionResult<Student>> Login(LoginDTO login)
        {
            return new EmptyResult();
        }        
    }
}

