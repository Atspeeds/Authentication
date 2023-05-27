using _01_Framework.Domain;
using StoreManager.Domain.ProductAgg;
using System.Collections.Generic;
using System.Linq;

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

        public void Edit(double price)
        {
            Price = price;
        }


        public long CurrentCount()
        {
            var entry = Oprations.Where(x => x.ServiceInput).Sum(c => c.Count);

            var output = Oprations.Where(x => !x.ServiceInput).Sum(c => c.Count);


            return entry - output;
        }

        public void ImportIntoWarehouse(long count, long Character, string description)
        {

            var entry = CurrentCount() + count;

            var opration = new InventoryOpration(Id, count, InventoryServiceInputs.Import, Character, description,entry);

            Oprations.Add(opration);

            IsInStock = entry > 0;
        }

        public void ExpelIntoWarehouse(long count, long Character, string description)
        {

            var Exit = CurrentCount() - count;

            var opration = new InventoryOpration(Id, count, InventoryServiceInputs.TakeOut, Character, description,Exit);

            Oprations.Add(opration);

            IsInStock = Exit > 0;
        }

    }
}
