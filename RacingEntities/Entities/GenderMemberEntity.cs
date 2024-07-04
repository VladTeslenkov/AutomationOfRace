using RacingEntities.Entities.RaceEntities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RacingEntities.Entities
{
    public class GenderMemberEntity
    {
            [Column(TypeName = "id")]
            public int Id { get; set; }

            [Column(TypeName = "name")]
            [Required]
            public string Name { get; set; }

            [Column(TypeName = "short_name")]
            [Required]
            public string ShortName { get; set; }

            public ICollection<RaceClassEntity> RaceClass { get; set; }
            public RacingMemberEntity? RacingMemberEntity { get; set; }


    }
}

