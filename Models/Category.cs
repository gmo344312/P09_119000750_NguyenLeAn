using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MvcMovie.Models
{
    public class Category
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [MaxLength(200)]
        public String? Name { get; set; } 
        [Required]
        
        public String? Content { get; set; }
        public ICollection<News>? News { get; set;}
    }
}