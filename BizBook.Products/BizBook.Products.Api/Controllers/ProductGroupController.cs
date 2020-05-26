using BizBook.Common.Library.Attributes;
using BizBook.Common.Library.Controllers;
using BizBook.Products.Api.Models.Entities;
using BizBook.Products.Api.Models.RequestModels;
using BizBook.Products.Api.Models.ViewModels;
using BizBook.Products.Api.Services.Interfaces;
using Microsoft.ApplicationInsights;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace BizBook.Products.Api.Controllers
{
    [BizBookAuthorization]
    [ApiController]
    public class ProductGroupController : BaseController<ProductGroup, ProductGroupRequestModel, ProductGroupViewModel, ProductGroupBasicViewModel>
    {
        private readonly IProductGroupService service;

        public ProductGroupController(IProductGroupService service, TelemetryClient client)
            : base(service, "ProductGroupController", client)
        {
            this.service = service;
        }
    }
}