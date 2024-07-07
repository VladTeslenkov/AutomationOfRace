
using System.ComponentModel.DataAnnotations;
using RacingPractice;

namespace RacingEntities.Entities
{
    public class Country : Entity
    {
      
        [Required]
        public string Name { get; set; }

        
    }
}
