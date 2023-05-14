using _01_Framework.Application;
using StoreManager.Application.Contract.Inventory;
using StoreManager.Domain.InventoryAgg;
using System.Collections.Generic;

namespace StoreManager.Application
{
    public class InventoryApplication : INventoryApplication
    {

        private readonly INventoryRepository _inventoryRepository;

        public InventoryApplication(INventoryRepository inventoryRepository)
        {
            _inventoryRepository = inventoryRepository;
        }

        public ActionResponse Create(CreateInventory command)
        {
            ActionResponse response = new ActionResponse();

            if (_inventoryRepository.Exists(x => x.ProductId == command.ProductId))
                return response.Failed(ServiceMessage.DuplicateRecord);

            var inventory = new Inventory(command.ProductId, command.Price);

            _inventoryRepository.Create(inventory);

            _inventoryRepository.Save();


            return response.Success();

        }

        public List<InventoryViewModel> Search(SearchInventory search)
        {
            return _inventoryRepository.Search(search);
        }
    }
}
