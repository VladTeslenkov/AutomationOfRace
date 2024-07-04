using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RacingEntities.Entities.VehicleInfoEntity;

namespace RacingEntities.Entities.Vehicle
{
    public class VehicleEntity
    {
        [Column(TypeName = "id")]
        public int Id { get; set; }

        public VehicleBrandEntity brand { get; set; }

        public VehicleModelEntity model { get; set; }

        public List<RacingMemberEntity> members { get; set; }

        [Column(TypeName = "engine_power")]
        [Required]
        public double EnginePower { get; set; }

        [Column(TypeName = "engine_volume")]
        [Required]
        public double EngineVolume {  get; set; }

        [Column(TypeName = "production_year")]
        [Required]
        public short ProductionYear {  get; set; }

        [Column(TypeName = "model_name")]
        [Required]
        public string ModelName {  get; set; }
        public ICollection<RacingMemberEntity> racingMembers { get; set; }

    }
}
