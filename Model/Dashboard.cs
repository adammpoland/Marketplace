using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Marketplace.Model
{
    public class Dashboard
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public int Store { get; set; }

        [Required]
        public string Buyer { get; set; }

        [Required]
        public string ItemPurchased { get; set; }
        
        [Required]
        public string SellerId { get; set; }

        [Required]
        public string ShippingAddress { get; set; }

       
    }
}
