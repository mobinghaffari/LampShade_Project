using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _0_Framework.Application;

namespace ShopManagement.Application.Contarcts.Product
{
    public interface IProductApplication
    {
        OperationResult Create(CreateProduct command);
        OperationResult Edit(EditProduct command);
        List<ProductViewModel>Search(ProductSearchModel searchModel);
        EditProduct GetDetails(long id);
        List<ProductViewModel> GetProducts();
    };
}
