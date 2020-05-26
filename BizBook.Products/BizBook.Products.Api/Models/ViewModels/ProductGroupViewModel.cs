using BizBook.Common.Library.Models.ViewModels;
using BizBook.Products.Api.Models.Entities;

namespace BizBook.Products.Api.Models.ViewModels
{
    public class ProductGroupViewModel : BaseViewModel<ProductGroup>
    {
        public string Name { get; set; }
    }

    public class ProductGroupBasicViewModel : BaseBasicViewModel<ProductGroup>
    {
        public string Name { get; set; }
    }
}