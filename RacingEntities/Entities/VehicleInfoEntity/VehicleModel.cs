
using System.ComponentModel.DataAnnotations;
using RacingPractice;

namespace RacingEntities.Entities.VehicleInfoEntity
{
    public class VehicleModel : Entity
    {
       
        [Required]
        public string Name { get; set; }

        public VehicleType VehicleType { get; set; }

        public VehicleBrand? Brand { get; set; }
        public int? BrandID { get; set; }
    }
}
