using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace RaceDayApi.Models;

public class Participant
{
    

    public int ParticipantId { get; set; }

   
    public required string FirstName { get; set; }


    public required string LastName { get; set; }

    public required string Email { get; set; }

    public required string PhoneNumber { get; set; }

 
    public DateTime DateOfBirth { get; set; }
    

}
