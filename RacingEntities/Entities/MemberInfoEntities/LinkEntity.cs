using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RacingEntities.Entities.MemberInfoEntities
{
    public class LinkEntity
    {
        [Column(TypeName = "id")]
        public int Id { get; set; }

        [Column(TypeName = "link")]
        [Required]
        public string Link { get; set; }

        [Column(TypeName = "description")]
        [Required]
        public string Description { get; set; }
        public RacingMemberEntity? RacingMemberEntity { get; set; }

    }
}
