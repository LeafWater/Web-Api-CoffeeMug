using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CoffeeMug.Models
{
    public class Product
    {
        public int Id { get; set; } 
        [Required]                              //Validation by Data Annotations, Id is not set as 'required' here but it's required by UPDATE/DELETE
        [StringLength(100)]
        public string Name { get; set; }
        [Required]
        [Range(float.Epsilon, float.MaxValue)]  //Price cannot be negative.
        public float Price { get; set; }
    }
}
