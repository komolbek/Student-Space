using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using StudentPlus.DomainModels;
using StudentPlus.DTOs;

namespace StudentPlus.Controllers
{
    [Route("api/[controller]")]
    public class SupervisorController : Controller
    {
        // GET: api/Supervisor
        [HttpGet]
        [Route("")]
        public async Task<ActionResult<IEnumerable<Supervisor>>> Get()
        {
            // Return list of supervisors
            return new List<Supervisor>();
        }

        // GET: api/Supervisor/{id}
        [HttpGet]
        [Route("{id}")]
        public async Task<ActionResult<Supervisor>> GetById(int id)
        {
            // Return supervisor with the specified ID
            return new Supervisor(2, "", "", "", "", "");
        }

        // POST: api/Supervisor
        [HttpPost]
        public async Task<ActionResult<Supervisor>> Register(Supervisor supervisor)
        {
            // Add supervisor to database and return the registered supervisor
            return new Supervisor(2, "", "", "", "", "");
        }

        // PUT: api/Supervisor/{id}
        [HttpPut]
        [Route("{id}")]
        public async Task<ActionResult<Supervisor>> Update(int id, Supervisor supervisor)
        {
            // Update supervisor in the database and return the updated supervisor
            return new Supervisor(2, "", "", "", "", "");
        }

        // DELETE: api/Supervisor/{id}
        [HttpDelete]
        [Route("{id}")]
        public async Task<ActionResult<Supervisor>> Delete(int id)
        {
            // Delete supervisor from the database and return the deleted supervisor
            return new Supervisor(2, "", "", "", "", "");
        }

        // POST: api/Supervisor/Login
        [HttpPost]
        [Route("Login")]
        public async Task<ActionResult<Supervisor>> Login(LoginDTO login)
        {
            return new EmptyResult();
        }
    }
}