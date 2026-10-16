using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace RaceDayApi.Models
{
    public class Organiser
    {

        public int OrganiserId { get; set; }

         public required string OrganiserName { get; set; }

        public required string Email { get; set; }

        public required string Phone { get; set; }
        

    }
}
