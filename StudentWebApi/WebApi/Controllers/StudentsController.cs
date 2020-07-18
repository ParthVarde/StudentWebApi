using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebApi.Models;

namespace WebApi.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class StudentsController : ControllerBase
    {
        private readonly StudentContext context;

        public StudentsController(StudentContext context)
        {
            this.context = context;

            context.Database.EnsureCreated();
        }

        [HttpGet]
        public async Task<IActionResult> GetAllStudents()
        {
            var student = await context.Students.ToArrayAsync();

            if(student == null)
            {
                return NotFound();
            }

            return Ok(student);
        }

        [HttpGet, Route("{id}")]
        public async Task<IActionResult> GetStudent(int id)
        {
            var student = await context.Students.FindAsync(id);

            if(student == null)
            {
                return NotFound();
            }

            return Ok(student);
        }
    }
}