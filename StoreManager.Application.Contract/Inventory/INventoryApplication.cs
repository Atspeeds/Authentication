using _01_Framework.Application;
using System.Collections.Generic;

namespace StoreManager.Application.Contract.Inventory
{
    public interface INventoryApplication
    {
        ActionResponse Create(CreateInventory command);
        ActionResponse Edit(EditInventory command);
        List<InventoryViewModel> Search(SearchInventory search);
        ActionResponse Increase(IncreaseInventory command);
        ActionResponse Decrease(DecreaseInventory command);
        EditInventory GetDetails(long id);
        long CurrentCount(long id);
       
    }
}
