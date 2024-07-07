using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RacingPractice;

namespace RacingEntities.Entities.VehicleInfoEntity
{
    public class VehicleType : Entity
    {
        
        [Required]
        public string Name { get; set; }

       
        public string Description { get; set; } = "";
        public RaceEntities.Race? Race { get; set; }
        public int? RaceID { get; set; }

    }
}
