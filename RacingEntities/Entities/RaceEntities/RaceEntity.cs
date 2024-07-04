using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RacingEntities.Entities.VehicleInfoEntity;

namespace RacingEntities.Entities.RaceEntities
{
    public class RaceEntity
    {
        [Column(TypeName = "id")]
        public  int Id { get; set; }

        [Column(TypeName = "name")]
        [Required]
        public string Name { get; set; }

        [Column(TypeName = "description")]
        [Required]
        public string Description { get; set; } = string.Empty;
        [Column(TypeName = "race_location")]
        [Required]
        public string RaceLocation { get; set; } = string.Empty;

        [Column(TypeName = "race_date")]
        [Required]
        public DateTime RaceDate { get; set; }

        [Column(TypeName = "max_members_count")]
        [Required]
        public int MaxCountMembers { get; set; }

        [Column(TypeName = "min_members_count")]
        [Required]
        public int MinimalCountMembers { get; set; }

        [Column(TypeName = "regulation_link")]
        [Required]
        public string RegulationLink { get; set; }

        public ICollection<RaceClassEntity> RaceClasses{ get; set; }
        public ICollection<OrganizerEntity> Organizer { get; set; }
        public ICollection<TeamEntity> Teams { get; set; }

    }
}
