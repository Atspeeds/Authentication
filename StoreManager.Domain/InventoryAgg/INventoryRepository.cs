using _01_Framework.Domain;
using StoreManager.Application.Contract.Inventory;
using System.Collections.Generic;

namespace StoreManager.Domain.InventoryAgg
{
    public interface INventoryRepository : IRepositoryBase<long, Inventory>
    {
        List<InventoryViewModel> Search(SearchInventory search);
        EditInventory Details(long id);
        List<OprationViewModel> ShowLog(long id);
    }
}
