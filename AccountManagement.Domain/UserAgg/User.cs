using _01_Framework.Domain;
using AccountManagement.Domain.RoleAgg;

namespace AccountManagement.Domain.UserAgg
{
    public class User : EntityBase
    {
        public string FullName { get; private set; }
        public string UserName { get; private set; }
        public string Password { get; private set; }
        public bool Status { get; private set; }
        public long RoleId { get; private set; }
        public Role Role { get; private set; }

        public User(string fullName, string userName, string password)
        {
            FullName = fullName;
            UserName = userName;
            Password = password;
            Status = true;
            RoleId = RolesUser.NormalUser;
        }

        public void InActive()
        {
            Status = false;
        }

        public void Active()
        {
            Status = true;
        }


    }
}
