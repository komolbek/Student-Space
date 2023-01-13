using System.ComponentModel;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using StudentPlus.DomainModels;
using StudentPlus.User;
using StudentPlus.DTOs;
using StudentPlus.Interfaces;
using StudentPlus.Enums;

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

        // GET: api/Student/BySupervisor/{id}
        [HttpGet]
        [Route("{id}")]
        public async Task<ActionResult<Student>> GetAllBySupervisor(string id)
        {
            return new EmptyResult();
        }

        // POST: api/Students
        [HttpPost]
        public async Task<ActionResult<Student>> Register(Student student)
        {
            // Validate incoming student
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            // Add student to database
            var result = await Task.Run(() => this._userAccount.RegisterNewAccountAsync(student));

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
        public async Task<ActionResult<Student>> Update(string id, Student student)
        {
            if (id != student.StudentId)
            {
                return BadRequest();
            }

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            try
            {
                IUser updatedStudent = (Student) await _userAccount.UpdateAccountDetailsAsync((IUser)student, UserType.Student);
                return Ok(updatedStudent);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex);
            }
        }

        // DELETE: api/Students/{id}
        [HttpDelete]
        [Route("{id}")]
        public async Task<ActionResult<Student>> Delete(string id)
        {
            if (string.IsNullOrWhiteSpace(id))
            {
                return BadRequest("UserId cannot be null or whitespace");
            }

            var userType = UserType.Student;
            var success = await _userAccount.DeleteAccountAsync(id, userType);
            if (!success)
            {
                return NotFound("No student account was found with the userId.");
            }

            return NoContent();
        }

        

        // POST: api/Students/Login
        [HttpPost]
        [Route("Login")]
        public async Task<ActionResult<Student>> Login(LoginDTO loginData)
        {
            if (loginData == null)
                return BadRequest("Login details are empty.");

            var student = await _userAccount.LoginAsync(loginData.UserNumber, loginData.UserPassword, loginData.UserType);

            if (student == null)
                return NotFound("No student found with the provided credentials.");

            return Ok(student);
        }

        // GET: api/Students/Logout
        [HttpGet]
        [Route("Logout")]
        public async Task<ActionResult<bool>> Logout()
        {
            try
            {
                //await _userAccountService.LogoutAsync();
                return Ok(true);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}

