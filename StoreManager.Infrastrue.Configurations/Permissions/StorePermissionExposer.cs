using _01_Framework.Infrastrue;
using System.Collections.Generic;

namespace StoreManager.Infrastrue.Configurations.Permissions
{
    public class StorePermissionExposer : IPermissionExposer
    {
        public Dictionary<string, List<PermissionDto>> Expose()
        {
            return new Dictionary<string, List<PermissionDto>>()
            {
                {
                    "Product",new List<PermissionDto>()
                    {
                        new PermissionDto(1,"ListProduct"),
                        new PermissionDto(2,"CreateProduct"),
                        new PermissionDto(3,"EditProduct"),

                    }

                },
                {
                    "Inventory",new List<PermissionDto>()
                    {
                        new PermissionDto(10,"LogInventory"),
                        new PermissionDto(20,"CreateInventory"),
                        new PermissionDto(30,"EditInventory"),
                        new PermissionDto(20,"IncreaseInventory"),
                        new PermissionDto(30,"DecreaseInventory"),

                    }
                }

            };
        }
    }
}
