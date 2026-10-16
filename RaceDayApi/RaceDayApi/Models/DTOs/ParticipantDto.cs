using Microsoft.Identity.Client;

namespace RaceDayApi.Models.DTOs
{
    public class ParticipantDto
    {
        public int Id{get; set; } 
        public required string ParticipantName { get; set; }
        public required string ParticipantEmail { get; set; }
        public required string ParticipantPhone { get; set; }

        public DateTime DateOfBirth { get; set; }
        public required string Gender { get; set; }
        public required string Address { get; set; }
        public Event Event { get; set; } = null!;
    }
}
