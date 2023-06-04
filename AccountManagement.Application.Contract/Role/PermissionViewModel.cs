using System.Collections.Generic;

namespace AccountManagement.Application.Contract.Role
{
    public class PermissionViewModel
    {
        public List<string> Permission { get; set; }
        public string Name { get; set; }
        public long RoleId { get; set; }
    }
}