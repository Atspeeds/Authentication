namespace _01_Framework.Application
{
    public class AuthViewModel
    {
        public long Id { get; set; }
        public string FullName { get; set; }
        public string UserName { get; set; }
        public bool Status { get; set; }

        public AuthViewModel(long id, string fullName, string userName, bool status)
        {
            Id = id;
            FullName = fullName;
            UserName = userName;
            Status = status;
        }
    }
}