using System.ComponentModel.DataAnnotations;

namespace Mission06_Eaton.Models
{
    public class Application
    {
        [Key]
        [Required]
        public int MovieID { get; set; }
        [Required] 
        public required string Category { get; set; }
        [Required]
        public required string Title { get; set; }
        [Required]
        public required int Year { get; set; }
        [Required]
        public required string Director { get; set; }
        [Required]
        public required string Rating { get; set; }
        public bool Edited { get; set; }
        public string? LentTo { get; set; }
        [StringLength(25)]
        public string? Notes { get; set; }
    }
}
