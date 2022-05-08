using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ExpenseTracker.Models {
    public class Expense {

        [Key]
        public int Id { get; set; }

        [Required]
        public DateTime Date { get; set; }
        public decimal Amount { get; set; }

        [ForeignKey(nameof(Category))]
        public Category Category { get; set; }
        public int CategoryID { get; set; }
    }
}
