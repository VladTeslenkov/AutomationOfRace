using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RacingEntities.Entities.RaceEntities
{
    public class TeamEntity
    {
        [Column(TypeName = "id")]
        public int Id { get; set; }

        [Column(TypeName = "name")]
        [Required]
        public string Name { get; set; }

        [Column(TypeName = "team_photo")]
        public string TeamPhoto { get; set; } = null;

        public ICollection<RacingMemberEntity> Members { get; set; }
        public ICollection<RaceEntity> Race { get; set; }
    }
}
