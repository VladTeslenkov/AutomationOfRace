using RacingEntities.Entities.VehicleInfoEntity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RacingPractice;

namespace RacingEntities.Entities.RaceEntities
{
    public class RaceClass : Entity
    {
        [Required]
        public string Name { get; set; }

        [Required]
        public string Description { get; set; } = string.Empty;

        public ICollection<Team> Teams { get; set; }

        public ICollection<VehicleType> VehicleTypes { get; set; }
        public ICollection<GenderMember> GenderMember { get; set; }
        public ICollection<CategoryMember> CategoryMember { get; set; }
    }
}
