using RaceDayApi.Controllers;
using RaceDayApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Raceday.Tests
{
    public class OganiserControllerTests
    {
        public class OrganiserControllerTests
        { 

            [Fact]

            public async Task CreateOrganiser_Should_Add_Organiser()
            {
                var context = TestDbFactory.Create();
                var controller = new OrganiserController(context);

                var organiser = new Organiser
                {
                    OrganiserName = "RaceDay Team",
                    Email = "admin@raceday.com",
                    Phone = "0123456789"
                };

                await controller.AddOrganiser(organiser);

                Assert.Single(context.Organisers);
            }
        }
    }
}

