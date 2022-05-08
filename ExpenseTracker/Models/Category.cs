using System.ComponentModel.DataAnnotations;

namespace ExpenseTracker.Models {
    public class Category {

        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(maximumLength: 60, ErrorMessage = "Name cannot be longer than 60 characters.")]
        public string Name { get; set; }
    }
}
