using Microsoft.AspNetCore.Http.HttpResults;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data;
using System.Security.Cryptography.Xml;
using System.Timers;

namespace RaceDayApi.Models
{
    public class Result
    {
        public int ResultId{ get; set; }

        public int RegistrationId{ get; set; }

        public TimeSpan FinishTime { get; set; }

        public int Position { get; set; }

        public required string Category { get; set; }

        public required string EventName { get; set; }
    }
}
