using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
