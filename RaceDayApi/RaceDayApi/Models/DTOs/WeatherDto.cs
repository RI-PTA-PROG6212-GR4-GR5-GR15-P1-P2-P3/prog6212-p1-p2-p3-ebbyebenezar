namespace RaceDayApi.Models.DTOs
{
    public class WeatherDto
    {
        public int WeatherId { get; set; }
        public required string WeatherConditions { get; set; }
        public double Temperature { get; set; }
        public double Humidity { get; set; }

    }
}
