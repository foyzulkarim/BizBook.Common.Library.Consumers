﻿using System;
using System.Linq;
using System.Linq.Expressions;
using BizBook.Common.Library.Models.RequestModels;
using BizBook.Common.Library.Models.ViewModels;
using BizBook.Products.Api.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace BizBook.Products.Api.Models.RequestModels
{
    public class ProductDetailRequestModel : RequestModel<ProductDetail>
    {
        public int OnHand { get; set; }

        public bool IsProductActive { get; set; }

        public string WarehouseId { get; set; }

        public bool IsFinishedProduct { get; set; }

        public ProductDetailRequestModel(string keyword, string orderBy = "Modified", string isAscending = "False") :
            base(keyword, orderBy, isAscending)
        {
        }

        protected override Expression<Func<ProductDetail, bool>> GetExpression()
        {
            if (!string.IsNullOrWhiteSpace(Keyword))
            {
                ExpressionObj = x =>
                    x.ProductCategory.Name.ToLower().Contains(Keyword)
                    || x.Name.ToLower().Contains(Keyword)
                    || x.BarCode.ToLower().Contains(Keyword)
                    || x.ProductCode.ToLower().Contains(Keyword);
            }

            if (IsProductActive)
            {
                ExpressionObj = ExpressionObj.And(x => x.IsActive == IsProductActive);
            }

            if (IsFinishedProduct)
            {
                ExpressionObj = ExpressionObj.And(x => x.IsRawProduct == false);
            }

            if (ParentId.IdIsOk())
            {
                ExpressionObj = ExpressionObj.And(x => x.ProductCategoryId == ParentId);
            }

            if (OnHand > 0)
            {
                ExpressionObj = ExpressionObj.And(x => x.OnHand <= OnHand);
            }

            ExpressionObj = ExpressionObj.And(x => x.ShopId == ShopId);
            ExpressionObj = ExpressionObj.And(GenerateBaseEntityExpression());
            return ExpressionObj;
        }

        public override IQueryable<ProductDetail> IncludeParents(IQueryable<ProductDetail> queryable)
        {
            return queryable.Include(x => x.ProductCategory);
        }

        public override Expression<Func<ProductDetail, DropdownViewModel<ProductDetail, TV>>> Dropdown<TV>()
        {
            return x => new DropdownViewModel<ProductDetail, TV>()
            {
                Id = x.Id,
                Text = x.Name,
                Data = x.ToViewModel<ProductDetail, TV>()
            };
        }
    }
}
