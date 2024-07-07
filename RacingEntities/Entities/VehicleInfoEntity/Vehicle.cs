using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RacingEntities.Entities.VehicleInfoEntity;
using RacingPractice;

namespace RacingEntities.Entities.Vehicle
{
    public class Vehicle : Entity
    {
       

        public VehicleBrand brand { get; set; }

        public VehicleModel model { get; set; }

        public List<RacingMember> members { get; set; }

        
        [Required]
        public double EnginePower { get; set; }

        
        [Required]
        public double EngineVolume {  get; set; }

        
        [Required]
        public short ProductionYear {  get; set; }

      
        [Required]
        public string ModelName {  get; set; }
        public ICollection<RacingMember> racingMembers { get; set; }

    }
}
