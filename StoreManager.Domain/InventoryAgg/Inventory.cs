using _01_Framework.Domain;
using StoreManager.Domain.ProductAgg;
using System.Collections.Generic;

namespace StoreManager.Domain.InventoryAgg
{
    public class Inventory : EntityBase
    {
        public long ProductId { get; private set; }
        public double Price { get; private set; }
        public bool IsInStock { get; private set; }



        //RelationShip
        public Product Product { get; private set; }
        public List<InventoryOpration> Oprations { get; private set; }

        public Inventory(long productId, double price)
        {
            ProductId = productId;
            Price = price;
            IsInStock = false;
        }


    }
    public class InventoryOpration
    {
        public long InvantoryId { get; private set; }
        public int Count { get; private set; }
        public bool ServiceInput { get; private set; }
        public string Description { get; private set; }
        //RelationShip
        public Inventory inventory { get; private set; }

        public InventoryOpration(long invantoryId, int count, bool serviceInput,string description)
        {
            InvantoryId = invantoryId;
            Count = count;
            ServiceInput = serviceInput;
            Description = description;
        }

    }
}
