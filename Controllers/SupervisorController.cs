using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Student_plus.Domain_models;
using Student_plus.DTOs;

namespace Student_plus.Controllers
{
    [Route("api/[controller]")]
    public class SupervisorController : Controller
    {
        // GET: api/Authorisation/Supervisors
        [HttpGet]
        [Route("Supervisors")]
        public async Task<ActionResult<IEnumerable<Supervisor>>> Get()
        {
            // Return list of supervisors
            return new List<Supervisor>();
        }

        // GET: api/Authorisation/Supervisors/{id}
        [HttpGet]
        [Route("Supervisors/{id}")]
        public async Task<ActionResult<Supervisor>> GetById(int id)
        {
            // Return supervisor with the specified ID
            return new Supervisor(2, "", "", "", "", "");
        }

        // POST: api/Authorisation/Supervisors
        [HttpPost]
        [Route("Supervisors")]
        public async Task<ActionResult<Supervisor>> Register(Supervisor supervisor)
        {
            // Add supervisor to database and return the registered supervisor
            return new Supervisor(2, "", "", "", "", "");
        }

        // PUT: api/Authorisation/Supervisors/{id}
        [HttpPut]
        [Route("Supervisors/{id}")]
        public async Task<ActionResult<Supervisor>> Update(int id, Supervisor supervisor)
        {
            // Update supervisor in the database and return the updated supervisor
            return new Supervisor(2, "", "", "", "", "");
        }

        // DELETE: api/Authorisation/Supervisors/{id}
        [HttpDelete]
        [Route("Supervisors/{id}")]
        public async Task<ActionResult<Supervisor>> Delete(int id)
        {
            // Delete supervisor from the database and return the deleted supervisor
            return new Supervisor(2, "", "", "", "", "");
        }

        // POST: api/Authorisation/Supervisors/Login
        [HttpPost]
        [Route("Supervisors/Login")]
        public async Task<ActionResult<Supervisor>> Login(LoginDTO login)
        {
            return new EmptyResult();
        }
    }
}

