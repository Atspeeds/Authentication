using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace AccountManagement.Application.Contract.Role
{
    public class CreateRole
    {
        public string Name { get; set; }

        [BindProperty]
        public List<int> permissions { get; set; }
    }
}