using StoreManager.Application.Contract.Product;
using System.Collections.Generic;

namespace StoreManager.Application.Contract.Inventory
{
    public class CreateInventory
    {
        public long ProductId { get;  set; }
        public string Product { get; set; }
        public double Price { get;  set; }
        public List<ProductViewModel> products { get; set; }
    }
}
