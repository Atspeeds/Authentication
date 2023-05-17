namespace StoreManager.Application.Contract.Inventory
{
    public class IncreaseInventory
    {
        public long InvantoryId { get; set; }
        public long Count { get; set; }
        public long Character { get; set; }
        public string Description { get; set; }
        public long CurrentCount { get; set; }
    }
}