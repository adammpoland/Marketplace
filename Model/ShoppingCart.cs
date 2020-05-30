using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Marketplace.Model
{
    public class ShoppingCart
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string ShoppingCartOwner { get; set; }

        [Required]
        public string StoreOwner { get; set; }

        [Required]
        public int StoreBoughtFrom { get; set; }

        [Required]
        public string ProdcuctName { get; set; }
        [Required]
        public int ProductId { get; set; }

        [Required]
        public int Quantity { get; set; }

        [Required]
        public string Price { get; set; }

        [Required]
        public string ShippingAddress { get; set; }
    }
}
