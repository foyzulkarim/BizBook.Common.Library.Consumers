using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using BizBook.Common.Library.Models;
using BizBook.Common.Library.Models.Entities;

namespace BizBook.Products.Api.Models.Entities
{
    public class ProductCategory : Entity
    {
        [Required]
        [IsIndex]
        [Column(TypeName = "varchar(128)")]
        public string Name { get; set; }

        [Required]
        [Column(TypeName = "varchar(128)")]
        public string ProductGroupId { get; set; }

        [ForeignKey("ProductGroupId")]
        public ProductGroup ProductGroup { get; set; }

        public virtual ICollection<ProductDetail> ProductDetails { get; set; } = new HashSet<ProductDetail>();
    }
}