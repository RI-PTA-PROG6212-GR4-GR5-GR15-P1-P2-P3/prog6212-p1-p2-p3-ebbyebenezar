namespace RaceDayApi.Models.DTOs
{
    public class ResultDto
    {
        public int ResultId { get; set; }
        public int ParticipantId { get; set; }
        public int EventId { get; set; }
        public int CategoryId { get; set; }
        public TimeSpan FinishTime { get; set; }
    }
    public interface IResultDto
    {
        int ResultId { get; set; }
        int ParticipantId { get; set; }
        int EventId { get; set; }
        int CategoryId { get; set; }
        TimeSpan FinishTime { get; set; }
    }

}
