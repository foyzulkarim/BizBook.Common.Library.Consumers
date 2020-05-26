using BizBook.Common.Library.Models.ViewModels;
using BizBook.Products.Api.Models.Entities;

namespace BizBook.Products.Api.Models.ViewModels
{
    public class ProductCategoryViewModel : BaseViewModel<ProductCategory>
    {
        public string Name { get; set; }

        public string ProductGroupId { get; set; }
    }

    public class ProductCategoryBasicViewModel : BaseBasicViewModel<ProductCategory>
    {
        public string Name { get; set; }

        public string ProductGroupId { get; set; }
    }
}