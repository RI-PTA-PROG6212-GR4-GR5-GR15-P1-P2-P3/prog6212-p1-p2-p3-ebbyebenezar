namespace RaceDayApi.Models.DTOs
{
    public class EventDto
    {
        public int EventId { get; set; }
        public required string EventName { get; set; }
        public DateTime EventDate { get; set; }


        public required string EventLocation { get; set; }
    }

}

 
