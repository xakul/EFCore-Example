using EFCore.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EFCore.Controllers
{
    [Route("api/employee")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private readonly AutoTempContext _context;

        public EmployeeController(AutoTempContext context)
        {
            this._context = context;
        }

        [HttpGet("get-employees")]
        public async Task<ActionResult<Employee>> GetUsers()
        {
            return await _context.Employees.FirstOrDefaultAsync();
        }
    }
}
