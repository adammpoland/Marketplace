using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Marketplace.Model
{
    public class Product
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string ProductName { get; set; }
        [Required]
        public string Price { get; set; }

        [Required]
        public int Quantity { get; set; }

        [Required]
        public string Store { get; set; }

        [Required]
        public string Description { get; set; }
        
        public string Picture { get; set; }
    }
}
