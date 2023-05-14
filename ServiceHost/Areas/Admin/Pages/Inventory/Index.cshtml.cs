using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using StoreManager.Application.Contract.Inventory;
using System.Collections.Generic;

namespace ServiceHost.Areas.Admin.Pages.Inventor
{
    public class IndexModel : PageModel
    {

        private readonly INventoryApplication _inventoryApplication;

        public IndexModel(INventoryApplication inventoryApplication)
        {
            _inventoryApplication = inventoryApplication;
        }

        public List<InventoryViewModel> inventories { get; set; }

        public void OnGet(SearchInventory search)
        {
            inventories = _inventoryApplication.Search(search);
        }


        public PartialViewResult OnGetCreate()
        {
            return Partial("./Create");
        }

        public JsonResult OnPostCreate(CreateInventory command)
        {
            var resualt = _inventoryApplication.Create(command);

            return new JsonResult(resualt.Message);
        }



    }
}
