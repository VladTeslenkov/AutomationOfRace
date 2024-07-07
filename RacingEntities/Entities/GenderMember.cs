using RacingEntities.Entities.RaceEntities;
using System.ComponentModel.DataAnnotations;
using RacingPractice;

namespace RacingEntities.Entities
{
    public class GenderMember : Entity
    {
           
            [Required]
            public string Name { get; set; }

            
            [Required]
            public string ShortName { get; set; }

            public ICollection<RaceClass> RaceClass { get; set; }
            public RacingMember? RacingMember { get; set; }
            public int? RacingMemberID { get; set; }

    }
}

