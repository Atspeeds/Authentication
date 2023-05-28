namespace AccountManagement.Application.Contract.User
{
    public class UserViewModel
    {
        public long Id { get; set; }
        public string FullName { get; set; }
        public string UserName { get; set; }
        public bool Status { get; set; }
        public string Role { get; set; }
        public long Roleid { get; set; }
    }
}