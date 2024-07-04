using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RacingEntities.Entities.VehicleInfoEntity
{
    public class VehicleTypeEntity
    {
        [Column(TypeName = "id")]
        public int Id { get; set; }

        [Column(TypeName = "name")]
        [Required]
        public string Name { get; set; }

        [Column(TypeName = "description")]
        public string Description { get; set; } = "";
        public RaceEntities.RaceEntity? Race { get; set; }

    }
}
