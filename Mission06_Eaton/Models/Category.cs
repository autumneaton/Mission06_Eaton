using System.ComponentModel.DataAnnotations;

namespace Mission06_Eaton.Models
{
    public class Category
    {
        [Key]
        public int CategoryID { get; set; }
        [Required]
        public required string CategoryName { get; set; }
    }
}
