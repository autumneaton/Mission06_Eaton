using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Mission06_Eaton.Models
{
    public class Application
    {
        [Key]
        [Required]
        public int MovieID { get; set; }
        public int? CategoryID { get; set; }
        public Category? Category { get; set; }
        [Required(ErrorMessage = "You must enter a movie title")]
        public string Title { get; set; }
        [Required]
        [Range(1888, int.MaxValue, ErrorMessage = "The movie can't be older than 1888")]
        public int Year { get; set; }
        public string? Director { get; set; }
        public string? Rating { get; set; }
        [Required(ErrorMessage = "You must put yes or no")]
        public bool Edited { get; set; }
        // the ? allows for nulls
        public string? LentTo { get; set; }
        [Required(ErrorMessage = "You must put yes or no")]
        public bool CopiedToPlex { get; set;}
        // allow only 25 characters
        [StringLength(25)]
        public string? Notes { get; set; }
    }
}
