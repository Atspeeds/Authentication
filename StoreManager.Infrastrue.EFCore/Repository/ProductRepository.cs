using _01_Framework.Application;
using _01_Framework.Infrastrue;
using Microsoft.EntityFrameworkCore;
using StoreManager.Application.Contract.Product;
using StoreManager.Domain.ProductAgg;
using System.Collections.Generic;
using System.Linq;

namespace StoreManager.Infrastrue.EFCore.Repository
{
    public class ProductRepository : RepositoryBase<long, Product>, IProductRepository
    {

        private readonly ShopContext _shopContext;

        public ProductRepository(ShopContext shopContext) : base(shopContext)
        {
            _shopContext = shopContext;
        }


        public EditProduct GetDetails(long id)
        {
            return _shopContext.Products
                .Select(x => new EditProduct
                {
                    Id = x.Id,
                    Name = x.Name,
                    PictureName = x.Picture,
                    Description = x.Description,
                    ShortDescription = x.ShortDescription,
                    Code = x.Code,
                }).FirstOrDefault(x => x.Id == id);

        }


        public List<ProductViewModel> Search(SearchProduct search)
        {
            var Query = _shopContext.Products
                .Select(x => new ProductViewModel()
                {
                    Id = x.Id,
                    Name = x.Name.FixViewText(),
                    Picture=x.Picture,
                    Code = x.Code,
                    Description = x.Description,
                    CreationDate = x.CreationDate.ToFarsi(),
                    ShortDescription = x.ShortDescription,
                    
                });

            if(!string.IsNullOrWhiteSpace(search.Name))
                Query=Query.Where(x=>x.Name.Contains(search.Name));

            if (!string.IsNullOrWhiteSpace(search.Code))
                Query = Query.Where(x => x.Code == search.Code);


            var Products = Query.AsNoTracking()
                .OrderByDescending(x => x.Id).ToList();


            return Products;

        }

    }
}
