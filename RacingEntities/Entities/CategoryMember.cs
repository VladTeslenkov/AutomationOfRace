using RacingEntities.Entities.RaceEntities;
using RacingPractice;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
