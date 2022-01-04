using System.Collections.Generic;
using _0_Framework.Domain;
using ShopManagement.Application.Contarcts.Product;
using ShopManagement.Application.Contarcts.ProductPicture;

namespace ShopManagement.Domain.ProductPictureAgg
{
    public interface IProductPictureRepository:IRepository<long,ProductPicture>
    {
        EditProductPicture GetDetails(long id);
        List<ProductPictureViewModel> Search(ProductPictureSearchModel searchModel);
    }
}
