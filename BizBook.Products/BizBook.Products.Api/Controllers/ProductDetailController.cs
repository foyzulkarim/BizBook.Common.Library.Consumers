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
    public class ProductDetailController : BaseController<ProductDetail, ProductDetailRequestModel, ProductDetailViewModel, ProductDetailBasicViewModel>
    {
        private readonly IProductDetailService service;
        
        public ProductDetailController(IProductDetailService service, TelemetryClient client)
            : base(service, "ProductDetailController", client)
        {
            this.service = service;
        }
    }
}