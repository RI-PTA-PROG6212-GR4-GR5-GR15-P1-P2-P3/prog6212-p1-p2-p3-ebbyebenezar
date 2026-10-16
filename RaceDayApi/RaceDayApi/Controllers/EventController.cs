using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RaceDayApi.Data;
using RaceDayApi.Models;

namespace RaceDayApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EventController : ControllerBase
    {
        private readonly AppDbContext _context;

        public EventController(AppDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<IActionResult> GetEvents()
        {
            return Ok(await _context.Events.ToListAsync());
        }
        [HttpPost]
        public async Task<IActionResult> AddEvent(Event ev)
        {
            _context.Events.Add(ev);
            await _context.SaveChangesAsync();

            return Ok(ev);
        }

           
    }
}
