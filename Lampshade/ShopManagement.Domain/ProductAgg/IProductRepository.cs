using System.Collections.Generic;
using _0_Framework.Domain;
using ShopManagement.Application.Contarcts.Product;
using ShopManagement.Domain.ProductCategoryAgg;

namespace ShopManagement.Domain.ProductAgg
{
    public interface IProductRepository : IRepository<long, Product>
    {
        EditProduct GetDetail(long id);
        List<ProductViewModel> Search(ProductSearchModel searchModel);
    }
}
