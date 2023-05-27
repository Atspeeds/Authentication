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

        public ActionResponse Edit(EditInventory command)
        {
            ActionResponse response = new ActionResponse();

            var inventory = _inventoryRepository.Get(command.id);

            if (inventory == null) return response.Failed(ServiceMessage.NoRecordFound);


            if (_inventoryRepository.Exists(x => x.Id != command.id))
                return response.Failed(ServiceMessage.DuplicateRecord);


            inventory.Edit(command.Price);

            _inventoryRepository.Save();

            return response.Success();
        }

        public long CurrentCount(long id)
        {
            var inventory = _inventoryRepository.Get(id);

            return inventory.CurrentCount();
        }

        public ActionResponse Decrease(DecreaseInventory command)
        {
            ActionResponse response = new ActionResponse();

            if (command.Count <= 0) return response.Failed(ServiceMessage.NumberLimit);

            long character = 1;

            var inventory = _inventoryRepository.Get(command.InvantoryId);

            if (inventory == null) return response.Failed(ServiceMessage.NoRecordFound);

            inventory.ExpelIntoWarehouse(command.Count, character, command.Description);

            _inventoryRepository.Save();

            return response.Success();
        }

        public ActionResponse Increase(IncreaseInventory command)
        {
            ActionResponse response = new ActionResponse();

            if (command.Count <= 0) return response.Failed(ServiceMessage.NumberLimit);

            long character = 1;

            var inventory = _inventoryRepository.Get(command.InvantoryId);

            if (inventory == null) return response.Failed(ServiceMessage.NoRecordFound);

            inventory.ImportIntoWarehouse(command.Count, character, command.Description);

            _inventoryRepository.Save();

            return response.Success();

        }

        public List<InventoryViewModel> Search(SearchInventory search)
        {
            return _inventoryRepository.Search(search);
        }

        public EditInventory GetDetails(long id)
        {
           return _inventoryRepository.Details(id);
        }

        public List<OprationViewModel> ShowInventoryLog(long id)
        {
            return _inventoryRepository.ShowLog(id);
        }
    }
}
