namespace StoreManager.Application.Contract.Inventory
{
    public class OprationViewModel
    {
        public long id { get; set; }
        public bool ServiceInput { get; set; }
        public long Count { get; set; }
        public string CreationDate { get; set; }
        public long CurrentCount { get; set; }
        public long Character { get; set; }
        public string Description { get; set; }
    }
}
