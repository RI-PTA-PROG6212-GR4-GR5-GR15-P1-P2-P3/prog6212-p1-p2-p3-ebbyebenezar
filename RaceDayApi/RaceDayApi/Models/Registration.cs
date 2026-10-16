using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Security.Cryptography.Xml;
using System.Text.Json.Serialization;

namespace RaceDayApi.Models
{
    public class Registration
    {


        public int RegistrationId { get; set; }

        public int ParticipantId { get; set; }

        public int EventId { get; set; }

        [JsonIgnore]
        public required Event Event { get; set; }

        [JsonIgnore]
        public required Participant Participant { get; set; }
       public int RegistrationNumber { get; set; }
        public DateTime RegistrationDate { get; set; }
        public decimal TotalAmount { get; set; }
        


    }
}
