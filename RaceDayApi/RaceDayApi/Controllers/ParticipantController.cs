using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RaceDayApi.Data;
using RaceDayApi.Models;
using Microsoft.EntityFrameworkCore;
namespace RaceDayApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
       
public class ParticipantController : ControllerBase
    {
        private readonly AppDbContext _context;

        public ParticipantController(AppDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<IActionResult> GetParticipants()
        {
            return Ok(await _context.Participants.ToListAsync());
        }

        [HttpPost]
        public async Task<IActionResult> AddParticipant(Participant participant)
        {
            _context.Participants.Add(participant);
            await _context.SaveChangesAsync();

            return Ok(participant);


        }
        }
}
