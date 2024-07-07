using RacingPractice;
using System.ComponentModel.DataAnnotations;


namespace RacingEntities.Entities
{
    public class Citizenship : Entity
    {
        
        [Required]
        public Country Country { get; set; }
        public RacingMember? RacingMember { get; set; }
        public int? RacingMemberID { get; set; }
    }
}
