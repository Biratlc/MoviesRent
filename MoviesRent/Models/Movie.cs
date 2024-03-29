﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Entity;
using System.Web;
using System.ComponentModel.DataAnnotations;
namespace MoviesRent.Models
{
    public class Movie
    {
        public int Id { get; set; }

        [Required]
        [StringLength(255)]
        public string Name { get; set; } 

        [Display(Name = "Genre")]
        [Required]
        public Genre Genre { get; set; }

        public byte GenreId { get; set; }

        public DateTime DateAdded { get; set; }

        [Display(Name = "Released Date")]
        public DateTime ReleaseDate { get; set; }

        [Display(Name = "Number in Stock")]  
        public byte NumberInStock
        {
            get; set;
        }
    }
}