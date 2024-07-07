using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RacingPractice;

namespace RacingEntities.Entities.MemberInfoEntities
{
    public class Photo : Entity
    {
      
        [Required]
        public string BinaryData { get; set; }
        public RacingMember? RacingMember { get; set; }
        public int? RacingMemberID { get; set; }
    }
}
