
using System.ComponentModel.DataAnnotations;
using RacingPractice;

namespace RacingEntities.Entities.RaceEntities
{
    public class Team : Entity
    {
       
        [Required]
        public string Name { get; set; }

       
        public string TeamPhoto { get; set; } = null;

        public ICollection<RacingMember> Members { get; set; }
        public ICollection<Race> Race { get; set; }
    }
}
