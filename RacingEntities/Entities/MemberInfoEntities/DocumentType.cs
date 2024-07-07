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
    public class DocumentType : Entity
    { 

        [Required]
        public string Name { get; set; }

        [Required]
        public string Description { get; set; }
    }
}
