
using System.ComponentModel.DataAnnotations;
using RacingPractice;

namespace RacingEntities.Entities.MemberInfoEntities
{
    public class Link : Entity
    {
       
        [Required]
        public string Links { get; set; }

        [Required]
        public string Description { get; set; }
        public RacingMember? RacingMember { get; set; }
        public int? RacingMemberID { get; set; }

    }
}
