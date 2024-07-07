
using System.ComponentModel.DataAnnotations;
using RacingPractice;

namespace RacingEntities.Entities
{
    public class Flat : Entity
    {
        [Required]
        public string Name { get; set; }
    }
}
