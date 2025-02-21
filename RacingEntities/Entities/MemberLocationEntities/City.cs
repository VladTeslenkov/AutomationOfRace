﻿
using System.ComponentModel.DataAnnotations;
using RacingPractice;

namespace RacingEntities.Entities
{
    public class City : Entity
    {
        [Required]
        public string Name { get; set; }

        public ICollection<Street> Streets { get; set; }
    }
}