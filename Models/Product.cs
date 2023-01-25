using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Fiorello.Models
{
    public class Product : BaseEntity
    {
        public string Title { get; set; }
        public string Description { get; set; }
        [Column(TypeName ="decimal(18,4)")]
        public decimal Price { get; set; }
        public DateTime CreateTime { get; set; }
        public int CategoryId { get; set; }
        public Category Category { get; set; }
        public ICollection<ProductImage>  ProductImages{ get; set; }
        
    }
}
