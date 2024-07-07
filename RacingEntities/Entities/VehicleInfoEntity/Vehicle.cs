
using System.ComponentModel.DataAnnotations;
using RacingPractice;

namespace RacingEntities.Entities.VehicleInfoEntity
{
    public class Vehicle : Entity
    {
       

        public VehicleBrand? brand { get; set; }
        public int? brandID { get; set; }

        public VehicleModel? model { get; set; }
        public int? modelID { get; set; }

        
        [Required]
        public double EnginePower { get; set; }

        
        [Required]
        public double EngineVolume {  get; set; }

        
        [Required]
        public short ProductionYear {  get; set; }

      
        [Required]
        public string ModelName {  get; set; }

        public ICollection<RacingMember> RacingMembers { get; set; }

    }
}
