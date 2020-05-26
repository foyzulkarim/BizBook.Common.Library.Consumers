using System;
using System.Linq.Expressions;
using BizBook.Common.Library.Models.RequestModels;
using BizBook.Common.Library.Models.ViewModels;
using BizBook.Products.Api.Models.Entities;

namespace BizBook.Products.Api.Models.RequestModels
{
    public class ProductGroupRequestModel : RequestModel<ProductGroup>
    {
        public ProductGroupRequestModel(string keyword, string orderBy = "Modified", string isAscending = "False") :
            base(keyword, orderBy, isAscending)
        {
        }
        
        public bool IsProductGroupActive { get; set; }

        protected override Expression<Func<ProductGroup, bool>> GetExpression()
        {
            if (!string.IsNullOrWhiteSpace(Keyword))
            {
                ExpressionObj = x => x.Name.ToLower().Contains(Keyword);
            }
            if (IsProductGroupActive)
            {
                ExpressionObj = ExpressionObj.And(x => x.IsActive == IsProductGroupActive);
            }
            ExpressionObj = ExpressionObj.And(x => x.ShopId == ShopId);
            ExpressionObj = ExpressionObj.And(GenerateBaseEntityExpression());
            return ExpressionObj;
        }

        public override Expression<Func<ProductGroup, DropdownViewModel<ProductGroup,TV>>> Dropdown<TV>()
        {
            return x => new DropdownViewModel<ProductGroup,TV>()
            {
                Id = x.Id,
                Text = x.Name,
                Data = x.ToViewModel<ProductGroup, TV>()
            };
        }
    }
}