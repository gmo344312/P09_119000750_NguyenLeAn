using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MvcMovie.Models
{
    public class News
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [MaxLength(200)]
        [MinLength(50)]
        public String? Title { get; set; }
        [Required]
        public String? ImageUrl { get; set; }
        [Required]
        [MaxLength(500)]
        [MinLength(100)]
        public String? Content { get; set; }
        [Required]
        public String? Author { get; set; }
        public DateTime CreatedAt { get; set; }
        
    [ForeignKey("CateID")]
    public Category ?Cate { get; set; }
    public ICollection<comment> ?comments { get; set;}
    }
}