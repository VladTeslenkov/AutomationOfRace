using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RacingEntities.Entities.VehicleInfoEntity
{
    public class VehicleModelEntity
    {
        [Column(TypeName = "id")]
        public int Id { get; set; }

        [Column(TypeName = "name")]
        [Required]
        public string Name { get; set; }

        public VehicleTypeEntity VehicleType { get; set; }

        public VehicleBrandEntity? Brand { get; set; }
    }
}
