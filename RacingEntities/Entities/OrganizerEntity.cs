using RacingEntities.Entities.RaceEntities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RacingEntities.Entities
{
    public class OrganizerEntity
    {
        [Column (TypeName = "id")]
        public int Id { get; set; }

        [Column(TypeName = "name")]
        [Required]
        public string Name { get; set; }

        [Column(TypeName = "OGRN")]
        [Required]
        public string OGRN { get; set; }

        [Column(TypeName = "INN")]
        [Required]
        public string INN { get; set; }

        [Column(TypeName = "KPP")]
        [Required]
        public string KPP { get; set; }


        [Column(TypeName = "OKPO")]
        [Required]
        public string OKPO { get; set; }


        [Column(TypeName = "OKVED")]
        [Required]
        public string OKVED { get; set; }


        [Column(TypeName = "payment_account")]
        [Required]
        public string PaymentAccount { get; set; }

        [Column(TypeName = "correspondent_account")]
        [Required]
        public string CorrespondentAccount { get; set; }

        [Column(TypeName = "BIK")]
        [Required]
        public string BIK { get; set; }

        [Column(TypeName = "surname_head")]
        [Required]
        public string SurnameHead { get; set; }

        [Column(TypeName = "name_head")]
        [Required]
        public string NameHead { get; set; }

        [Column(TypeName = "patronymic_head")]
        [Required]
        public string PatronymicHead { get; set; }

        public ICollection<RaceEntity> Race { get; set; }

    }
}
