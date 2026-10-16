using Microsoft.EntityFrameworkCore;
using RaceDayApi.Controllers;
using RaceDayApi.Data;
using RaceDayApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Raceday.Tests
{
    public class RegistrationControllerTests
    {
        [Fact]
        public async Task CreateParticipant_ShouldAddParticipant()
        {
            var options = new DbContextOptionsBuilder<AppDbContext>()
                .UseInMemoryDatabase(databaseName: "ParticipantDb")
                .Options;

            using var context = new AppDbContext(options);

            var controller = new ParticipantController(context);

            var participant = new Participant
            {
                FirstName = "John",
                LastName = "Smith",
                Email = "john@test.com",
                PhoneNumber = "123456789"
            };

            await controller.AddParticipant(participant);

            Assert.Single(context.Participants);
        }
    }
}
