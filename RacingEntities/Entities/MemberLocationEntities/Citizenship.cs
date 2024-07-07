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
    public class Citizenship : Entity
    {
        
        [Required]
        public Country Country { get; set; }
        public RacingMember? RacingMemberEntity { get; set; }

    }
}
