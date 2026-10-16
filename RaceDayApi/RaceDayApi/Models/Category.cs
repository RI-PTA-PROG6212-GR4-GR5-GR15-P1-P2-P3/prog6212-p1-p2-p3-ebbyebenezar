using System.ComponentModel.DataAnnotations;
using System.Data;

namespace RaceDayApi.Models
{
    public class Category
    {
     

        public int CategoryId { get; set; }

       
        public required string CategoryName { get; set; }

        public double Distance { get; set; }

        public decimal EntryFee { get; set; }
    }
}
