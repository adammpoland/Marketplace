using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Marketplace.Model
{
    public class Store
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string StoreName { get; set; }
        [Required]
        public string StoreOwner { get; set; }
        [Required]
        public string StoreDescription { get; set; }



        public string ImageText { get; set; }
        public string Picture { get; set; }                  
    
        
    
    }
}
