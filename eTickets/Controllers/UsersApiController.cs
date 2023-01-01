
using eTickets.Data;
using eTickets.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace eTickets.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class UsersApiController : ControllerBase
    {
        private readonly AppDbContext _context;
        public UsersApiController(AppDbContext context)
        {
            _context = context;
        }
        // GET: api/<UsersApiController>
        [HttpGet]
        public async Task<ActionResult<List<ApplicationUser>>> Get()
        {
            var u = await _context.Users.ToListAsync();
            if(u is null)
            {
                return NoContent();
            }
            return u;
            
        }

    }
}
