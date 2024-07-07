using RacingEntities.Entities.VehicleInfoEntity;
using System.ComponentModel.DataAnnotations;
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
