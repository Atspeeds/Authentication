using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using StoreManager.Application.Contract.Inventory;
using StoreManager.Application.Contract.Product;
using System.Collections.Generic;

namespace ServiceHost.Areas.Admin.Pages.Inventor
{
    public class IndexModel : PageModel
    {

        private readonly INventoryApplication _inventoryApplication;

        private readonly IProductApplication _productApplication;

        public IndexModel(INventoryApplication inventoryApplication, IProductApplication productApplication)
        {
            _inventoryApplication = inventoryApplication;
            _productApplication = productApplication;
        }

        public List<InventoryViewModel> inventories { get; set; }


        public void OnGet(SearchInventory search)
        {
            inventories = _inventoryApplication.Search(search);
        }


        public PartialViewResult OnGetCreate()
        {
            var model = new CreateInventory()
            {
                products = _productApplication.GetSelectList()
            };
            return Partial("./Create", model);
        }

        public IActionResult OnPostCreate(CreateInventory command)
        {
            var resualt = _inventoryApplication.Create(command);

            return RedirectToPage("Index"); ;
        }


        public PartialViewResult OnGetEdit(long id)
        {
            var inventoryModel = _inventoryApplication.GetDetails(id);
            return Partial("./Edit", inventoryModel);
        }

        public IActionResult OnPostEdit(EditInventory command)
        {
            var resualt = _inventoryApplication.Edit(command);

            return RedirectToPage("Index");
        }




        public PartialViewResult OnGetIncrease(long id)
        {
            var Increase = new IncreaseInventory()
            {
                InvantoryId = id,
                CurrentCount = _inventoryApplication.CurrentCount(id)
            };
            return Partial("./Increase", Increase);
        }

        public IActionResult OnPostIncrease(IncreaseInventory command)
        {
            var resualt = _inventoryApplication.Increase(command);
            return RedirectToPage("Index");
        }



        public PartialViewResult OnGetDecrease(long id)
        {
            var Decreas = new DecreaseInventory()
            {
                InvantoryId = id,
                CurrentCount = _inventoryApplication.CurrentCount(id)
            };
            return Partial("./Decrease", Decreas);
        }

        public IActionResult OnPostDecrease(DecreaseInventory command)
        {
            var resualt = _inventoryApplication.Decrease(command);
            return RedirectToPage("Index");
        }



    }
}
