﻿
using System.ComponentModel.DataAnnotations;
using RacingPractice;

namespace RacingEntities.Entities.RaceEntities
{
    public class Race : Entity
    {
        
        [Required]
        public string Name { get; set; }

        
        [Required]
        public string Description { get; set; } = string.Empty;

        [Required]
        public string RaceLocation { get; set; } = string.Empty;

        [Required]
        public DateTime RaceDate { get; set; }

        [Required]
        public int MaxCountMembers { get; set; }

        
        [Required]
        public int MinimalCountMembers { get; set; }

        [Required]
        public string RegulationLink { get; set; }

        public ICollection<RaceClass> RaceClasses{ get; set; }
        public ICollection<Organizer> Organizer { get; set; }
        public ICollection<Team> Teams { get; set; }

    }
}
