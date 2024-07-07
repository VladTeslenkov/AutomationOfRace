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
    public class VehicleBrand : Entity
    {
        [Required]
        public string Name { get; set; }

        public  ICollection<VehicleModel> VehicleModels { get; set; }
    }
}
