using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using BizBook.Common.Library.Models;
using BizBook.Common.Library.Models.Entities;

namespace BizBook.Products.Api.Models.Entities
{
    public class ProductGroup : Entity
    {
        [IsIndex]
        [Required]
        [Column(TypeName = "varchar(128)")]
        public string Name { get; set; }

        public virtual ICollection<ProductCategory> ProductCategories { get; set; } = new HashSet<ProductCategory>();
    }
}