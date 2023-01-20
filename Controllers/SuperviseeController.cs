using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Student_plus.Services;
using StudentPlus.DomainModels;

namespace Student_plus.Controllers
{
    [Route("api/[controller]")]
    public class SuperviseeController : Controller
    {
        private readonly SuperviseeService _superviseeService;

        public SuperviseeController(SuperviseeService superviseeService)
        {
            _superviseeService = superviseeService;
        }

        /// <summary>
        /// assigns students to a particular supervisor
        /// </summary>
        /// <param name="students">students that will be assigned to supervisor using its id</param>
        /// <param name="supervisorId">is used for connecting students</param>
        [HttpPost]
        [Route("/{supervisorId}/students")]
        public async Task<IActionResult> AddStudents([FromBody] List<string> studentNumbers, string supervisorId)
        {
            var result = await _superviseeService.AssignStudentsToSupervisorAsync(studentNumbers, supervisorId);
            if (result != null)
            {
                return Ok(result);
            }
            else
            {
                return BadRequest();
            }
        }

        [HttpPost]
        [Route("/{supervisorId}/student")]
        public async Task<IActionResult> AddStudent([FromBody] string studentNumber, string supervisorId)
        {
            var result = await _superviseeService.AssignStudentToSupervisorAsync(studentNumber, supervisorId);
            if (result != null)
            {
                return Ok(result);
            }
            else
            {
                return BadRequest();
            }
        }
    }
}

