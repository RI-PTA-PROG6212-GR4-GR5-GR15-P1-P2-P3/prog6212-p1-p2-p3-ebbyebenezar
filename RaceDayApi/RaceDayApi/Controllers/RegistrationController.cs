using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RaceDayApi.Data;
using RaceDayApi.Models;
using Microsoft.EntityFrameworkCore;

namespace RaceDayApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RegistrationController : ControllerBase
    {
        private readonly AppDbContext _context;

        public RegistrationController(AppDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<IActionResult> GetRegistrations()
        {
            return Ok(await _context.Registrations.ToListAsync());
        }

        [HttpPost]
        public async Task<IActionResult> Addregistration(Registration registration)
        {
            _context.Registrations.Add(registration);
            await _context.SaveChangesAsync();

            return Ok(registration);
        }

        public async Task Register(Registration registration)
        {
            throw new NotImplementedException();
        }
    }
}
