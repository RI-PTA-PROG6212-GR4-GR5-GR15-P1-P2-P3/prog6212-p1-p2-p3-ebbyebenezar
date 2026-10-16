using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RaceDayApi.Data;
using RaceDayApi.Models;
using Microsoft.EntityFrameworkCore;

namespace RaceDayApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrganiserController : ControllerBase
    {
        private readonly AppDbContext _context;

        public OrganiserController(AppDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<IActionResult> GetOrganisers()
        {
            return Ok(await _context.Organisers.ToListAsync());
        }

        [HttpPost]
        public async Task<IActionResult> AddOrganiser(Organiser organiser)
        {
            _context.Organisers.Add(organiser);
            await _context.SaveChangesAsync();

            return Ok(organiser);
        }
    }
}
