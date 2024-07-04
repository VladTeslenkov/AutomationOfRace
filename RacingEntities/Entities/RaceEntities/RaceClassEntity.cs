using RacingEntities.Entities.VehicleInfoEntity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RacingEntities.Entities.RaceEntities
{
    public class RaceClassEntity
    {
        [Column(TypeName = "id")]
        public int Id { get; set; }

        [Column(TypeName = "name")]
        [Required]
        public string Name { get; set; }

        [Column(TypeName = "description")]
        [Required]
        public string Description { get; set; } = string.Empty;

        public ICollection<TeamEntity> Teams { get; set; }

        public ICollection<VehicleTypeEntity> VehicleTypes { get; set; }
        public ICollection<GenderMemberEntity> GenderMember { get; set; }
        public ICollection<CategoryMember> CategoryMember { get; set; }
    }
}
