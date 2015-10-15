using System;
using System.ComponentModel.DataAnnotations;

namespace CatalogManager.Models
{
    public class Product
    {
        [Key]
        public int ProductId { get; set; }
        [MaxLength(50), MinLength(2)]
        public string Name { get; set; }
        public decimal Price { get; set; }
    }
}
