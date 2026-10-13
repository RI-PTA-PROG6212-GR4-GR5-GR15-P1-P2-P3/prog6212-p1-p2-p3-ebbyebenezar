using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data;
using System.Security.Cryptography.Xml;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace RaceDayApi.Models
{
    public class @event
    {
       
        public int EventID { get; set; }

        public int OrganiserID { get; set; }

       
        public string EventName { get; set; }

        public DateTime EventDate { get; set; }

      
        public string Location { get; set; }

        
        public string EventType { get; set; } = "Running";

       
        public organiser Organiser { get; set; }
    }
}
