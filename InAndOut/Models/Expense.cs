using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace InAndOut.Models
{
    public class Expense
    {
        [Key]
        public int Id { get; set; }
        [DisplayName("Expense name")]
        [Required]
        public string ExpenseName { get; set; }
        [DisplayName("Cost")]
        [Required]
        [Range(1, double.MaxValue, ErrorMessage ="Amount must be greater than 0!")]
        public double ExpenseCost { get; set; }
    }
}
