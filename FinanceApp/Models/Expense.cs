using System;
using System.ComponentModel.DataAnnotations;

namespace FinanceApp.Models
{
    public class Expense
    {
        // Add properties here
        public int Id { get; set; }
        [Required]
        public string Description { get; set; } = null!;
        [Required]
        [Range(0.01,Double.MaxValue,ErrorMessage ="Amount needs to be higher than")]
        public double Amount { get; set; }
        [Required]
        public String Category { get; set; } = null!;
        public DateTime Date { get; set; } =  DateTime.Now;

        

    }
}