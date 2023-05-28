using _01_Framework.Domain;
using AccountManagement.Domain.UserAgg;
using System.Collections.Generic;

namespace AccountManagement.Domain.RoleAgg
{
    public class Role : EntityBase
    {
        public string Name { get; set; }
        public List<Permission> Permissions { get; set; }
        public List<User> Users { get; private set; }

        public Role()
        {
           Permissions=new List<Permission>();
        }

        public Role(string name, List<Permission> permissions)
        {
            Name = name;
            Permissions = permissions;
        }





    }
}
