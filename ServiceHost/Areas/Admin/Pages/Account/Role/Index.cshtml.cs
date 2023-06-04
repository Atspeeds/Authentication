using AccountManagement.Application.Contract.Role;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Collections.Generic;

namespace ServiceHost.Areas.Admin.Pages.Account.Role
{
    public class IndexModel : PageModel
    {

        private readonly IRoleApplication _roleApplication;
      
        public IndexModel(IRoleApplication roleApplication)
        {
            _roleApplication = roleApplication;
        }

        public List<RoleViewModel> Roles { get; set; }

        public void OnGet(SearchRole search)
        {
            Roles = _roleApplication.Search(search);
            
        }

      
        //public PartialViewResult OnGetEdit(long id)
        //{
        //    var User = _userApplication.(id);
        //    return Partial("./Edit", product);
        //}

        //public IActionResult OnPostEdit(EditProduct command)
        //{
        //    var product = _productApplication.Edit(command);
        //    return RedirectToPage("/Index");
        //}

    }
}
