﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ProductsAPI.Models
{
    public class Products
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public int productId { get; set; }

        [MaxLength(50)]
        public string productName { get; set; }
        public decimal productPrice { get; set; }

        [MaxLength(100)]
        public string productCategories { get; set; }

        [MaxLength(150)]
        public string productImage { get; set; }

        [MaxLength(200)]
        public string productDescription { get; set; }
    }
}
