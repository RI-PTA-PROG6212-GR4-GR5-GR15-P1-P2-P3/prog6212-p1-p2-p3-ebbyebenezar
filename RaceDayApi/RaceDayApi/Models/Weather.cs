using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Security.Cryptography.Xml;

namespace RaceDayApi.Models
{
    public class Weather
    {

        public int WeatherId { get; set; }

        public int EventId { get; set; }

        public DateTime WeatherDate{get; set;}

    }
}