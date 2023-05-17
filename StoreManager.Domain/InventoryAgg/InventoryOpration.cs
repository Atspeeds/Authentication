using _01_Framework.Domain;

namespace StoreManager.Domain.InventoryAgg
{
    public class InventoryOpration : EntityBase
    {
        public long InvantoryId { get; private set; }
        public long Count { get; private set; }
        public bool ServiceInput { get; private set; }
        public long Character { get; private set; }
        public string Description { get; private set; }
        //RelationShip
        public Inventory inventory { get; private set; }

        public InventoryOpration(long invantoryId, long count, bool serviceInput, long character, string description)
        {
            InvantoryId = invantoryId;
            Count = count;
            ServiceInput = serviceInput;
            Character = character;
            Description = description;
        }
    }
}
