using Raceday.Tests;
using RaceDayApi.Controllers;
using RaceDayApi.Models;




namespace Raceday.Test
{
    public class EventControllerTests
    {

        [Fact]
        public async Task CreateEvent_ShouldAddEvent()
        {
            var context = TestDbFactory.Create();

            var controller = new EventController(context);

            var ev = new Event
            {
                EventName = "Race Day",
                Location = "Pretoria"
            };

            await controller.AddEvent(ev);

            Assert.Equal(1, context.Events.Count());
        }
    }
}