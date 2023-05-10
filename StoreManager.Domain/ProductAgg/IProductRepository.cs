using _01_Framework.Domain;
using StoreManager.Application.Contract.Product;
using System.Collections.Generic;

namespace StoreManager.Domain.ProductAgg
{
    public interface IProductRepository : IRepositoryBase<long, Product>
    {
        List<ProductViewModel> Search(SearchProduct search);
        EditProduct GetDetails(long id);

    }
}
