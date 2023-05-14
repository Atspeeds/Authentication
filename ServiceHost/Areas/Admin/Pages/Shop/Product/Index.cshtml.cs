using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using StoreManager.Application.Contract.Product;
using System.Collections.Generic;

namespace ServiceHost.Areas.Admin.Pages.Shop.Product
{
    public class IndexModel : PageModel
    {

        private readonly IProductApplication _productApplication;

        public IndexModel(IProductApplication productApplication)
        {
            _productApplication = productApplication;
        }

        public List<ProductViewModel> products { get; set; }

        public void OnGet(SearchProduct search)
        {
            products = _productApplication.Search(search);
        }


        public PartialViewResult OnGetCreate()
        {
            return Partial("./Create");
        }

        public JsonResult OnPostCreate(CreateProduct command)
        {
            var resualt = _productApplication.Create(command);

            return new JsonResult(resualt.Message);
        }


        public PartialViewResult OnGetEdit(long id)
        {
            var product = _productApplication.GetDetails(id);
            return Partial("./Edit", product);
        }

        public JsonResult OnPostEdit(EditProduct command)
        {
            var product = _productApplication.Edit(command);
            return new JsonResult(product.Message);
        }

    }
}
