using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CoffeeMug.Models
{
    public class Product
    {
        public Guid Id { get; set; } 
        [Required]                              // Validation by Data Annotations, Id is not set as 'required' here but to call methods PUT, DELETE Id must be given.
        [StringLength(100)]
        public string Name { get; set; }
        [Required]
        [Column(TypeName = "decimal(18,2)")]
        [Range(0.01, (double)decimal.MaxValue)] // Price not negative and not 0.
        public decimal Price { get; set; }
    }
}
