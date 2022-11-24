﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Fitbod.Models
{
    public class Exercise
    {
        [Key]
        public int ExerciseId { get; set; }
        [Required(ErrorMessage = "Indtast navn")] 
        public string Name { get; set; }
        [Required(ErrorMessage = "Indtast navn")]
        public string Musclegroup { get; set; }
        [Required]
        public string Description { get; set; }
        [Required]
        public string Image { get; set; }
        public ICollection<ExercisePlanEntry> ExercisePlanEntry { get; set; }

    }
}
