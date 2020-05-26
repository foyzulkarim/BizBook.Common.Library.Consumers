using BizBook.Common.Library.Models.ViewModels;
using BizBook.Products.Api.Models.Entities;

namespace BizBook.Products.Api.Models.ViewModels
{
    public class ProductDetailBasicViewModel : BaseBasicViewModel<ProductDetail>
    {
        public string Name { get; set; }

        public string BarCode { get; set; }

        public string ProductCode { get; set; }

        public double SalePrice { get; set; }

        public double DealerPrice { get; set; }

        public double DealerCashPrice { get; set; }

        public double DealerDuePrice { get; set; }

        public double FranchisePrice { get; set; }

        public double PartnershipPrice { get; set; }
    }


    public class ProductDetailViewModel : BaseViewModel<ProductDetail>
    {
        public string Name { get; set; }

        public string BarCode { get; set; }

        public string ProductCode { get; set; }

        public string Brand { get; set; }

        public bool IsRawProduct { get; set; }

        public bool HasUniqueSerial { get; set; } = false;

        public string UniqueSerial { get; set; }

        public double SalePrice { get; set; }

        public double DealerPrice { get; set; }

        public double CostPrice { get; set; }

        public double DealerCashPrice { get; set; }

        public double DealerDuePrice { get; set; }

        public double FranchisePrice { get; set; }

        public double PartnershipPrice { get; set; }

        public int StartingInventory { get; set; } = 0;

        public double Purchased { get; set; }

        public double Sold { get; set; }

        public double OnHand { get; set; }

        public int MinimumStockToNotify { get; set; }

        public string ProductCategoryId { get; set; }
    }
}
