using System.ComponentModel;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using StudentPlus.DomainModels;
using StudentPlus.User;
using StudentPlus.DTOs;
using StudentPlus.Interfaces;

namespace StudentPlus.Controllers
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
        public async Task<ActionResult<IEnumerable<Student>>> Get()
        {
            // Return list of students
            return new List<Student>();
        }

        // GET: api/Authorisation/Students/{id}
        [HttpGet]
        [Route("{id}")]
        public async Task<ActionResult<Student>> GetById(string id)
        {
            var student = _userAccount.Login(id, "");
            return Ok(student);
        }

        // POST: api/Authorisation/Students
        [HttpPost]
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
        [Route("{id}")]
        public async Task<ActionResult<Student>> Update(int id, Student student)
        {
            return new EmptyResult();
        }

        // DELETE: api/Authorisation/Students/{id}
        [HttpDelete]
        [Route("{id}")]
        public async Task<ActionResult<Student>> Delete(int id)
        {
            return new EmptyResult();
        }

        

        // POST: api/Authorisation/Students/Login
        [HttpPost]
        [Route("Login")]
        public async Task<ActionResult<Student>> Login(LoginDTO login)
        {
            return new EmptyResult();
        }        
    }
}

