namespace RaceDayApi.Models.DTOs
{
    public class OrganiserDto
    {
        public int Id { get; set; }
        public required string OrganiserName { get; set; }
        public required string OrganiserEmail { get; set; }
        public required string OrganiserPhone { get; set; }
    }
}
