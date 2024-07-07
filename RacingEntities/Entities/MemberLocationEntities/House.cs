using System.ComponentModel.DataAnnotations;
using RacingPractice;

namespace RacingEntities.Entities
{
    public class House : Entity
    {
        
        [Required]
        public string HouseNumber { get; set; }

        public Street? street { get; set; }
        public int? streetID { get; set; }
    }
}