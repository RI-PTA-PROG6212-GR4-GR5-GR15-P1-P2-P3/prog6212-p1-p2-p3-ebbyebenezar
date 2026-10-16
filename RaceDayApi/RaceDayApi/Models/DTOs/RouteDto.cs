namespace RaceDayApi.Models.DTOs
{
    public class RouteDto
    {
        public int RouteId { get; set; }
        public required string RouteName { get; set; }
        public double RouteDistance { get; set; }
        public required string weatherConditions { get; set; }
    }
}
