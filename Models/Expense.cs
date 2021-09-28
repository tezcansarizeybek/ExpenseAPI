using System;
using System.ComponentModel.DataAnnotations;

namespace ExpenseAPI.Models
{
    public class Expense
    {
        [Key]
        public Guid Uuid { get; set; }

        [Required]
        [MaxLength(100)]
        public string DESCPRIPTION { get; set; }
        [Required]
        public double TOTAL { get; set; }
        [Required]
        [MaxLength(20)]
        public string DATE { get; set; }
        [Required]
        [MaxLength(50)]
        public string CATEGORY { get; set; }
        public double GPSX { get; set; }
        public double GPSY { get; set; }
    }
}