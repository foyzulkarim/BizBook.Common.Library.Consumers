﻿using BizBook.Common.Library.Services;
using BizBook.Products.Api.Models.Entities;
using BizBook.Products.Api.Models.RequestModels;
using BizBook.Products.Api.Models.ViewModels;

namespace BizBook.Products.Api.Services.Interfaces
{
    public interface IProductCategoryService : IBaseService<ProductCategory, ProductCategoryRequestModel, ProductCategoryViewModel, ProductCategoryBasicViewModel>
    {
    }
}