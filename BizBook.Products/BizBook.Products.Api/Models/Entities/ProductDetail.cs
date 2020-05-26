using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using BizBook.Common.Library.Models;
using BizBook.Common.Library.Models.Entities;

namespace BizBook.Products.Api.Models.Entities
{
    public class ProductDetail : Entity
    {
        [IsIndex]
        [Required]
        [Column(TypeName = "varchar(128)")]
        public string Name { get; set; }

        [IsIndex]
        [Required]
        [Column(TypeName = "varchar(128)")]
        public string BarCode { get; set; }

        [IsIndex]
        [Required]
        [Column(TypeName = "varchar(128)")]
        public string ProductCode { get; set; }

        [IsIndex]
        [Required]
        [Column(TypeName = "varchar(128)")]
        public string Brand { get; set; }

        public bool IsRawProduct { get; set; }

        public bool HasUniqueSerial { get; set; } = false;

        [IsIndex]
        [Column(TypeName = "varchar(128)")]
        public string UniqueSerial { get; set; }

        [DataType(DataType.Currency)]
        public double SalePrice { get; set; }

        [DataType(DataType.Currency)]
        public double DealerPrice { get; set; }

        [DataType(DataType.Currency)]
        public double CostPrice { get; set; }

        [DataType(DataType.Currency)]
        public double DealerCashPrice { get; set; }

        [DataType(DataType.Currency)]
        public double DealerDuePrice { get; set; }

        [DataType(DataType.Currency)]
        public double FranchisePrice { get; set; }

        [DataType(DataType.Currency)]
        public double PartnershipPrice { get; set; }

        [Required]
        public int StartingInventory { get; set; } = 0;

        [Required]
        public double Purchased { get; set; }

        [Required]
        public double Sold { get; set; }

        [Required]
        public double OnHand { get; set; }

        public int MinimumStockToNotify { get; set; }
        
        [Required]
        public string ProductCategoryId { get; set; }

        [ForeignKey("ProductCategoryId")]
        public virtual ProductCategory ProductCategory { get; set; }
    }
}
