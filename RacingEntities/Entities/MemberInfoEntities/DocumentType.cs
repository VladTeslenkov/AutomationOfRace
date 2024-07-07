
using System.ComponentModel.DataAnnotations;
using RacingPractice;

namespace RacingEntities.Entities.MemberInfoEntities
{
    public class DocumentType : Entity
    { 

        [Required]
        public string Name { get; set; }

        [Required]
        public string Description { get; set; }
    }
}
