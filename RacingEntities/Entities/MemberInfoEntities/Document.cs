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
    public class Document:Entity
    {
        
        [Required]
        public string Name { get; set; }

        public DocumentType DocumentTypeEntity { get; set; }
        public RacingMember? RacingMemberEntity { get; set; }
    }
}
