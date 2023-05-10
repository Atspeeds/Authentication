using _01_Framework.Application;
using System.Collections.Generic;

namespace StoreManager.Application.Contract.Product
{
    public interface IProductApplication
    {
        ActionResponse Create(CreateProduct command);
        ActionResponse Edit(EditProduct command);
        List<ProductViewModel> Search(SearchProduct search);
        EditProduct GetDetails(long  id);
    }
}
