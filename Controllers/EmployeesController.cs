using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RestAPI.Models;

namespace RestAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeesController : ControllerBase
    {
        private readonly RestAPIContext _context;

        public EmployeesController(RestAPIContext context)
        {
            _context = context;
        }

        // GET: api/Employees
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Employee>>> Getemployees()
        {
            return await _context.employees.ToListAsync();
        }

        //----------------------------------- Check if email employee is valid and returns a Boolean -----------------------------------\\

        // GET: api/Employees/email
        [HttpGet("{email}")]
        public bool CheckEmail(string email)
        {
            return _context.employees.Any(e => e.email == email);
        }

        private bool EmployeeExists(long id)
        {
            return _context.employees.Any(e => e.id == id);
        }
    }
}
