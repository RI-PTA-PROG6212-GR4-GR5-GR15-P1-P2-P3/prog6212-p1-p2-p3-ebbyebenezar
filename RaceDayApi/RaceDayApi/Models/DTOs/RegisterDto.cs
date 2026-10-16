namespace RaceDayApi.Models.DTOs

{
    public class RegisterDto
    {
        public required string Email { get; set; }
        public required string Password  { get; set; }
        public required string Role { get; set; }
        public int Id { get; set; }
    }
}
