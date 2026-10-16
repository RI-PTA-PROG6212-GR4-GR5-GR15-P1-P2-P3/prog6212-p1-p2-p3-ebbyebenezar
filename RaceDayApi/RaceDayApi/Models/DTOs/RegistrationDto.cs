namespace RaceDayApi.Models.DTOs
{
    public class RegistrationDto
    {
        public int RegistrationId { get; set; }
        public int EventId { get; set; }
        public int CategoryId { get; set; }
        public int OrganiserId { get; set; }
        public DateTime RegistrationDateTime { get; set; }

    }
}
