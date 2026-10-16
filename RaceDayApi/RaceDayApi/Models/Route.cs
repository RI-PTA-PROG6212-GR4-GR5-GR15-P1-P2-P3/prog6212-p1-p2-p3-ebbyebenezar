using Microsoft.AspNetCore.Components.Routing;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Security.Cryptography.Xml;

namespace RaceDayApi.Models
{
    public class Route
    {


        public int EventId { get; set; }

        public required string RouteName { get; set; }

        public double Distance { get; set; }

        public required string Description { get; set; }

    }
}
