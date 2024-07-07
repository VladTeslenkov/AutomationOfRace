using RacingEntities.Entities.RaceEntities;
using RacingPractice;
using System.ComponentModel.DataAnnotations;

namespace RacingEntities.Entities
{
    public class Organizer : Entity
    {
       
        [Required]
        public string Name { get; set; }

        
        [Required]
        public string OGRN { get; set; }

       
        [Required]
        public string INN { get; set; }

       
        [Required]
        public string KPP { get; set; }


        
        [Required]
        public string OKPO { get; set; }


        
        [Required]
        public string OKVED { get; set; }


        
        [Required]
        public string PaymentAccount { get; set; }

        
        [Required]
        public string CorrespondentAccount { get; set; }

        
        [Required]
        public string BIK { get; set; }

        
        [Required]
        public string SurnameHead { get; set; }

        [Required]
        public string NameHead { get; set; }

        
        [Required]
        public string PatronymicHead { get; set; }

        public ICollection<Race> Race { get; set; }

    }
}
