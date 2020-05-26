using BizBook.Common.Library.Services;
using BizBook.Products.Api.Models.Db;
using BizBook.Products.Api.Models.Entities;
using BizBook.Products.Api.Models.RequestModels;
using BizBook.Products.Api.Models.ViewModels;
using BizBook.Products.Api.Services.Interfaces;

namespace BizBook.Products.Api.Services
{
    public class ProductDetailService : BaseService<ProductDetail, ProductDetailRequestModel, ProductDetailViewModel,ProductDetailBasicViewModel>, IProductDetailService
    {
        public ProductDetailService(ProductDbContext db) : base(db)
        {
        }
    }
}