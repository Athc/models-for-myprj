﻿using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ECOMMERCE.Models
{
    [Table("Product")]
    public class Product
    {
        public int ProductId { get; set; }

        [Required]
        [MaxLength(40)]
        public string? ProductName { get; set; }

  

        [Required]
        public double Price { get; set; }

        public string? Image { get; set; }

        [Required]
        public int CategoryId { get; set; }

        public Category Category { get; set; }

        public List<OrderDetail> OrderDetails { get; set; }

        public List<CartDetail> CartDetails { get; set; }

        [NotMapped]
        public string CategoryName { get; set; }
    }
}
