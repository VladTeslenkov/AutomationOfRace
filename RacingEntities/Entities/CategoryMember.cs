using RacingEntities.Entities.RaceEntities;
using RacingPractice;
using System.ComponentModel.DataAnnotations;


namespace RacingEntities.Entities
{
    public class CategoryMember : Entity
    {
       
        [Required]
        public string Name { get; set; }

       
        [Required]
        public string ShortName { get; set; }

       
        
        public string Description { get; set; }

        public ICollection<RaceClass> raceClasses { get; set; }
        public RacingMember? RacingMember { get; set; }
        public int? RacingMemberID { get; set; }
    }
}
