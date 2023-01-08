using System.ComponentModel;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Student_plus.User
{
    /// <summary>
    /// Controller for handling user account related actions.
    /// </summary>
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        //private readonly IUserService _userService;

        /// <summary>
        /// Constructor for the UserController class.
        /// </summary>
        /// <param name="userService">Service for interacting with user data.</param>
        public UserController()//IUserService userService)
        {
            //_userService = userService;
        }

        /// <summary>
        /// Registers a new user.
        /// </summary>
        /// <param name="user">User object containing account information.</param>
        /// <returns>The newly created user object.</returns>
        /// <response code="400">If the user object is invalid.</response>
        // POST: api/User/register
        [Description("Registers a new user")]
        [HttpPost("register")]
        public async Task<ActionResult<Student>> Register(Student user)
        {
            //var result = await _userService.AddAsync(user);
            //if (result == null)
            //{
            //    return BadRequest();
            //}
            return Ok();//result);
        }

        /// <summary>
        /// Authenticates a user.
        /// </summary>
        /// <param name="user">User object containing account information for authentication.</param>
        /// <returns>The authenticated user object.</returns>
        /// <response code="400">If the user object is invalid or authentication fails.</response>
        // POST: api/User/authenticate
        [Description("Authenticates a user")]
        [HttpPost("authenticate")]
        public async Task<ActionResult<Student>> Authenticate(Student user)
        {
            //var result = await _userService.AuthenticateAsync(user.StudentId, user.SupervisorId);
            //if (result == null)
            //{
            //    return BadRequest();
            //}
            return Ok();//result);
        }

        /// <summary>
        /// Updates a user's account information.
        /// </summary>
        /// <param name="user">User object containing updated account information.</param>
        /// <returns></returns>
        /// <response code="400">If the user object is invalid or the update fails.</response>
        // PUT: api/User/update
        
        [HttpPut("update")]
        [Description("Updates a user's account information")]
        public async Task<IActionResult> Update(Student user)
        {
            //var result = await _userService.UpdateAsync(user);
            //if (!result)
            //{
            //    return BadRequest();
            //}
            return Ok();
        }
    }
}

