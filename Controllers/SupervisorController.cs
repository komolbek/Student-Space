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
            return new EmptyResult();
        }

        // GET: api/Supervisor/{id}
        [HttpGet]
        [Route("{id}")]
        public async Task<ActionResult<Supervisor>> GetById(int id)
        {
            return new EmptyResult();
        }

        // POST: api/Supervisor
        [HttpPost]
        public async Task<ActionResult<Supervisor>> Register(Supervisor supervisor)
        {
            return new EmptyResult();
        }

        // PUT: api/Supervisor/{id}
        [HttpPut]
        [Route("{id}")]
        public async Task<ActionResult<Supervisor>> Update(int id, Supervisor supervisor)
        {
            return new EmptyResult();
        }

        // DELETE: api/Supervisor/{id}
        [HttpDelete]
        [Route("{id}")]
        public async Task<ActionResult<Supervisor>> Delete(int id)
        {
            return new EmptyResult();
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