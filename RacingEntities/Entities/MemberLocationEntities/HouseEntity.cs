using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System;

namespace RacingEntities.Entities
{
    public class HouseEntity
    {
        [Column(TypeName = "id")]
        public int Id { get; set; }

        [Column(TypeName = "house_number")]
        [Required]
        public string HouseNumber { get; set; }

        public StreetEntity street { get; set; }
    }
}