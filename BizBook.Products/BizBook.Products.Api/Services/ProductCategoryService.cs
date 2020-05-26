using BizBook.Common.Library.Services;
using BizBook.Products.Api.Models.Db;
using BizBook.Products.Api.Models.Entities;
using BizBook.Products.Api.Models.RequestModels;
using BizBook.Products.Api.Models.ViewModels;
using BizBook.Products.Api.Services.Interfaces;

namespace BizBook.Products.Api.Services
{
    public class ProductCategoryService : BaseService<ProductCategory, ProductCategoryRequestModel, ProductCategoryViewModel, ProductCategoryBasicViewModel>, IProductCategoryService
    {
        public ProductCategoryService(ProductDbContext db) : base(db)
        {
        }
    }
}