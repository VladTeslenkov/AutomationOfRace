using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RacingEntities.Entities
{
    public class CitizenshipEntity
    {
        [Column(TypeName = "id")]
        public int Id { get; set; }

        [Column(TypeName = "country")]
        [Required]
        public CountryEntity Country { get; set; }
        public RacingMemberEntity? RacingMemberEntity { get; set; }

    }
}
