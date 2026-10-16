using System.ComponentModel.DataAnnotations;

namespace RaceDayApi.Models
{
    public class Event
    {
        [Key]
        public int EventId { get; set; } 

        public string EventName { get; set; } = string.Empty;

        public DateTime EventDate { get; set; }
        public required string Location { get; set; }
    }
}

