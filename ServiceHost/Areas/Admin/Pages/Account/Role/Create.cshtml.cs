using _01_Framework.Infrastrue;
using AccountManagement.Application.Contract.Role;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;

namespace ServiceHost.Areas.Admin.Pages.Account.Role
{
    public class CreateModel : PageModel
    {
        public CreateRole command;

        private readonly IRoleApplication _roleApplication;
        private readonly IEnumerable<IPermissionExposer> _exposer;
        public List<SelectListItem> Permissions = new List<SelectListItem>();
        public CreateModel(IRoleApplication roleApplication, IEnumerable<IPermissionExposer> exposer)
        {
            _roleApplication = roleApplication;
            _exposer = exposer;
        }

        public void OnGet()
        {
            foreach (var exposer in _exposer)
            {
                var exposedPermissions = exposer.Expose();
                foreach (var (key, value) in exposedPermissions)
                {
                    var group = new SelectListGroup { Name = key };
                    foreach (var permission in value)
                    {
                        var item = new SelectListItem(permission.Name, permission.Code.ToString())
                        {
                            Group = group
                        };

                        Permissions.Add(item);

                    }
                }
            }
        }
        public IActionResult OnPost(CreateRole command)
        {
            var resualt = _roleApplication.Create(command);
             
            return RedirectToPage("/Index");
        }

    }
}
