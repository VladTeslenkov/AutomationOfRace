
using System.ComponentModel.DataAnnotations;
using RacingEntities.Entities.VehicleInfoEntity;
using RacingEntities.Entities.MemberInfoEntities;
using RacingEntities.Entities.RaceEntities;
using RacingPractice;

namespace RacingEntities.Entities
{
    public class RacingMember : Entity
    {
      
        [Required]
        public string Name { get; set; } 

        [Required]
        public string Surname { get; set; }

        [Required]
        public string Patronymic {  get; set; }

        [Required]
        public string NameInternational { get; set; }

        [Required]
        public string SurnameInternational { get; set; }

        [Required]
        public string PatronymicInternational { get; set; }

        [Required]
        public DateTime? Date { get; set; }

        public bool IsPublicProfile { get; set; } = true;

        public string Email { get; set; } = string.Empty;

        public DateTime? InsuranceDate { get; set; }

        [Required]
        public Country Country { get; set; }

        [Required]
        public City City { get; set; }

        [Required]
        public House House { get; set; }
        

        [Required]
        public Street Street { get; set; }

        public ICollection<Citizenship> Citizenship { get; set; }

        public ICollection<Photo> Photos { get; set; }

        public ICollection<Document> Documents { get; set; }

        public ICollection<Link> Links { get; set; }
        public ICollection<Team> Teams { get; set; }
        public ICollection<GenderMember> GenderMember { get; set; }
        public ICollection<CategoryMember> CategoryMember { get; set; }
        public ICollection<Vehicle> Vehicles { get; set; }

       
    }
}
