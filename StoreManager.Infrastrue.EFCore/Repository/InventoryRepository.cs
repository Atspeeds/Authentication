using _01_Framework.Application;
using _01_Framework.Infrastrue;
using Microsoft.EntityFrameworkCore;
using StoreManager.Application.Contract.Inventory;
using StoreManager.Domain.InventoryAgg;
using System.Collections.Generic;
using System.Linq;

namespace StoreManager.Infrastrue.EFCore.Repository
{
    public class InventoryRepository : RepositoryBase<long, Inventory>, INventoryRepository
    {
        private readonly ShopContext _shopContext;
        
        public InventoryRepository(ShopContext context) : base(context)
        {
            _shopContext = context;
        }

        public EditInventory Details(long id)
        {
            return _shopContext.Inventories
                .Include(p => p.Product)
                .Select(x => new EditInventory()
                {
                    id = x.Id,
                    Price = x.Price,
                    Product = x.Product.Name,
                }).FirstOrDefault(x => x.id == id);

        }

        public List<InventoryViewModel> Search(SearchInventory search)
        {
            var query = _shopContext.Inventories.Include(p => p.Product)
                .Select(x => new InventoryViewModel()
                {
                    Id = x.Id,
                    Price = x.Price,
                    Product = x.Product.Name,
                    IsInStock = x.IsInStock,
                    ProductId = x.ProductId
                });

            if (search.ProductId > 0)
                query = query.Where(x => x.ProductId == search.ProductId);


            return query.OrderByDescending(x => x.Id).ToList();

        }

        public List<OprationViewModel> ShowLog(long id)
        {
            var result = _shopContext.Inventories
                  .Where(x => x.Id == id)
                  .SelectMany(o => o.Oprations)
                   .Select(x => new OprationViewModel
                   {
                       id=x.Id,
                       Character = x.Character,
                       Description = x.Description,
                       ServiceInput = x.ServiceInput,
                       CreationDate=x.CreationDate.ToFarsi(),
                       Count=x.Count,
                       CurrentCount=x.CourrentCount,
                   }).ToList();

            return result;
        }
    }
}
