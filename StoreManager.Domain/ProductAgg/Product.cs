using _01_Framework.Domain;
using StoreManager.Domain.InventoryAgg;
using System.Collections.Generic;

namespace StoreManager.Domain.ProductAgg
{
    public class Product : EntityBase
    {

        public string Name { get; private set; }
        public string Picture { get; private set; }
        public string Description { get; private set; }
        public string ShortDescription { get; private set; }
        public string Code { get; private set; }

        //RelationShipt
        public List<Inventory> Inventories { get; private set; }

        public Product(string name, string picture, string description, string shortDescription, string code)
        {
            Name = name;
            Picture = picture;
            Description = description;
            ShortDescription = shortDescription;
            Code = code;
        }

        public void Edit(string name, string picture, string description, string shortDescription, string code)
        {
            Name = name;

            if(!string.IsNullOrWhiteSpace(picture))
            Picture = picture;

            Description = description;
            ShortDescription = shortDescription;
            Code = code;
        }

        

    }
}
