
using System.ComponentModel.DataAnnotations;
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
