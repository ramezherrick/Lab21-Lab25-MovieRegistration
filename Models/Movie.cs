using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Lab21_MovieRegisteration.Models
{
    public class Movie
    {
        [Required]
        [Range(1, int.MaxValue)]
        public int ID { get; set; }

        [Required]
        [StringLength(50,MinimumLength =1,ErrorMessage = "Invalid-Title: Please enter a title between 1 and 50 characters")]
        public string Title { get; set; }

        public string Genre { get; set; } 

        [Required]
        [Range(1880,2020)]
        public int Year { get; set; } 

        [Required]
        [StringLength(50, ErrorMessage ="Invalid-Please enter an actor's name less than 50 characters")]
        public string Actors { get; set; }

        [StringLength(50, ErrorMessage = "Invalid-Please enter an actor's name less than 50 characters")]
        public string Directors { get; set; }
    }
}
