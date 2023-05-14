namespace StoreManager.Application.Contract.Inventory
{
    public class InventoryViewModel
    {
        public long Id { get; set; }
        public string Product { get; set; }
        public long ProductId { get; set; }
        public double Price { get; set; }
        public bool IsInStock { get; set; }
    }
}