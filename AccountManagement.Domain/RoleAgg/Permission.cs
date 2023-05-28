using _01_Framework.Domain;

namespace AccountManagement.Domain.RoleAgg
{
    public class Permission : EntityBase
    {
        public string Access { get; private set; }
        public long RoleId { get; private set; }

        public Role Role { get; private set; }

        public Permission(string access, long roleId)
        {
            Access = access;
            RoleId = roleId;
        }
    }
}
