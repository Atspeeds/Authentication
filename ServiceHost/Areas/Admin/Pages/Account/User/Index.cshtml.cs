using AccountManagement.Application.Contract.User;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Collections.Generic;

namespace ServiceHost.Areas.Admin.Pages.Account.User
{
    public class IndexModel : PageModel
    {

        private readonly IUserApplication _userApplication;

        public IndexModel(IUserApplication userApplication)
        {
            _userApplication = userApplication;
        }

        public List<UserViewModel> Users { get; set; }

        public void OnGet(SearchUser search)
        {
            Users = _userApplication.Search(search);
        }


        public PartialViewResult OnGetCreate()
        {
            return Partial("./Create");
        }

        public IActionResult OnPostCreate(CreateUser command)
        {
            var resualt = _userApplication.Create(command);

            return RedirectToPage("/Index");
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
