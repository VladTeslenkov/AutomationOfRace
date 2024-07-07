
using System.ComponentModel.DataAnnotations;
using RacingPractice;

namespace RacingEntities.Entities
{
    public class Street : Entity
    {
        
        [Required]
        public string Name { get; set; }

        public ICollection<House> Houses { get; set; }
        public City? City { get; set; }
        public int? CityID { get; set; }

    }
}