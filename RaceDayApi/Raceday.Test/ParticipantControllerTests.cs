using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RaceDayApi.Controllers;
using RaceDayApi.Data;
using RaceDayApi.Models;

namespace Raceday.Tests
{
    public class ParticipantControllerTests
    {
        private AppDbContext CreateParticipants
        {
            get
            {
                var options = new DbContextOptionsBuilder<AppDbContext>()
                    .UseInMemoryDatabase(Guid.NewGuid().ToString())
                    .Options;

                return new AppDbContext(options);
            }
        }

        
    }
    
}
