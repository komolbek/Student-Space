using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Student_plus.DTOs;
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

        
        [HttpPost]
        [Route("/{supervisorId}/students")]
        public async Task<IActionResult> AddStudents([FromBody] List<SuperviseeDTO> studentNumbers, string supervisorId)
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
        public async Task<IActionResult> AddStudent([FromBody] SuperviseeDTO studentNumber, string supervisorId)
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

