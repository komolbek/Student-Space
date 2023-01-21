using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using StudentPlus.DomainModels;
using StudentPlus.DTOs;
using StudentPlus.Enums;
using StudentPlus.Interfaces;

namespace StudentPlus.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SupervisorController : ControllerBase
    {
        private readonly IUserAccount _userAccount;

        public SupervisorController(IUserAccount userAccount)
        {
            _userAccount = userAccount;
        }

        //// GET: api/Supervisor/BySupervisor/{id}
        //[HttpGet]
        //[Route("{id}")]
        //public async Task<ActionResult<Supervisor>> GetAllBySupervisor(string id)
        //{
        //    return new EmptyResult();
        //}

        // POST: api/Supervisor
        [HttpPost]
        public async Task<ActionResult<Supervisor>> Register(Supervisor supervisor)
        {
            // Validate incoming supervisor
            if (!ModelState.IsValid) 
            {
                return BadRequest(ModelState);
            }

            // Add supervisor to database
            var result = await Task.Run(() => this._userAccount.RegisterNewAccountAsync(supervisor));

            // Return the registered supervisor
            if (result != null)
            {
                return CreatedAtAction(nameof(Register), result);
            }
            else
            {
                return BadRequest("Unable to register supervisor");
            }
        }

        // PUT: api/Supervisor/{id}
        [HttpPut]
        [Route("{id}")]
        public async Task<ActionResult<Supervisor>> Update(string id, Supervisor supervisor)
        {
            if (id != supervisor.SupervisorId)
            {
                return BadRequest();
            }

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            try
            {
                IUser updatedSupervisor = (Supervisor)await _userAccount.UpdateAccountDetailsAsync((IUser)supervisor, UserType.Supervisor);
                return Ok(updatedSupervisor);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex);
            }
        }

        // DELETE: api/Supervisor/{id}
        [HttpDelete]
        [Route("{id}")]
        public async Task<ActionResult<Supervisor>> Delete(string id)
        {
            if (string.IsNullOrWhiteSpace(id))
            {
                return BadRequest("UserId cannot be null or whitespace");
            }

            var userType = UserType.Supervisor;
            var success = await _userAccount.DeleteAccountAsync(id, userType);
            if (!success)
            {
                return NotFound("No supervisor account was found with the userId.");
            }

            return NoContent();
        }



        // POST: api/Supervisor/Login
        [HttpPost]
        [Route("Login")]
        public async Task<ActionResult<Supervisor>> Login(LoginDTO loginData)
        {
            if (loginData == null)
                return BadRequest("Login details are empty.");

            var supervisor = await _userAccount.LoginAsync(loginData.UserNumber, loginData.UserPassword, loginData.UserType);

            if (supervisor == null)
                return NotFound("No supervisor found with the provided credentials.");

            return Ok(supervisor);
        }

        // GET: api/Supervisor/Logout
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

        // GET: api/Supervisor/{studentNumber}
        [HttpGet]
        [Route("{studentNumber}")]
        public async Task<ActionResult<Supervisor>> GetSupervisor(string studentNumber)
        {
            if (studentNumber == null)
                return BadRequest("Student number must be provided");

            Supervisor? supervisor = await _userAccount.GetSupervisor(studentNumber);

            if (supervisor == null)
                return NotFound("No supervisor found matching student number");

            return Ok(supervisor);
        }
    }
}