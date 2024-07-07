
using System.ComponentModel.DataAnnotations;
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
