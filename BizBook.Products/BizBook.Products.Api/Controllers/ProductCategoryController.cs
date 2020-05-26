using BizBook.Common.Library.Controllers;
using BizBook.Products.Api.Models.Entities;
using BizBook.Products.Api.Models.RequestModels;
using BizBook.Products.Api.Models.ViewModels;
using BizBook.Products.Api.Services.Interfaces;
using Microsoft.ApplicationInsights;
using Microsoft.AspNetCore.Mvc;

namespace BizBook.Products.Api.Controllers
{
    [ApiController]
    public class ProductCategoryController : BaseController<ProductCategory, ProductCategoryRequestModel, ProductCategoryViewModel, ProductCategoryBasicViewModel>
    {
        private readonly IProductCategoryService service;

        public ProductCategoryController(IProductCategoryService service, TelemetryClient client)
            : base(service, "ProductCategoryController", client)
        {
            this.service = service;
        }
    }
}