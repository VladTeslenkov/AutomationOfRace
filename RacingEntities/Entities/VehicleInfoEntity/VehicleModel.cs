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
    public class VehicleModel : Entity
    {
       
        [Required]
        public string Name { get; set; }

        public VehicleType VehicleType { get; set; }

        public VehicleBrand? Brand { get; set; }
    }
}
