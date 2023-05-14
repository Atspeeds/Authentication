using _01_Framework.Application;
using System.Collections.Generic;

namespace StoreManager.Application.Contract.Inventory
{
    public interface INventoryApplication
    {
        ActionResponse Create(CreateInventory command);
        List<InventoryViewModel> Search(SearchInventory search);

    }
}
