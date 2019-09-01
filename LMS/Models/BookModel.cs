
using System;
using System.ComponentModel.DataAnnotations;

namespace LMS.Models
{
    public class BookModel
    {
        [Key]
        public int Id { get; set; }
        
        public float ReplacementPrice { get; set; }

        [Required] public Boolean Status { get; set; } = false;
        
        [Required]
        [MaxLength(256)]
        public string Author { get; set; }
        
        [Required]
        [MaxLength(256)]
        public string Title { get; set; }
        
        [MaxLength(256)]
        public string Genre { get; set; }
        
        [Range(0, 5)]
        public float Rating { get; set; }
    }
}