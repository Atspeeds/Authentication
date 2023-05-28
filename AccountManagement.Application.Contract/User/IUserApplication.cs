using _01_Framework.Application;
using System.Collections.Generic;

namespace AccountManagement.Application.Contract.User
{
    public interface IUserApplication
    {
        ActionResponse Create(CreateUser command);
        ActionResponse Login(LoginViewModel command);
        List<UserViewModel> Search(SearchUser search);
    }
}

