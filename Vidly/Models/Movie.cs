﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Vidly.Models
{
    public class Movie
    {
        public int Id { get; set; }

        [Required]
        [StringLength(255)]
        public string Name { get; set; }

        [Required]
        public DateTime ReleaseDate { get; set; }
        
        public DateTime DateAdded { get; set; }

        public Genre Genre { get; set; }

        [Required]
        public int GenreId { get; set; }

        [Required]
        [Range(1, 20, ErrorMessage ="Stock should be between 1-20")]
        public int NumberInStock { get; set; }

        public int NumberAvailable { get; set; }
    }
}