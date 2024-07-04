using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RacingEntities.Entities.MemberInfoEntities
{
    public class PhotoEntity
    {
        [Column(TypeName = "id")]
        public int Id { get; set; }

        [Column(TypeName = "binary_data")]
        [Required]
        public string BinaryData { get; set; }
        public RacingMemberEntity? RacingMemberEntity { get; set; }

    }
}
