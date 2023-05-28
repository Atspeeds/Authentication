using _01_Framework.Domain;
using AccountManagement.Application.Contract.User;
using System.Collections.Generic;

namespace AccountManagement.Domain.UserAgg
{
    public interface IUserRepository : IRepositoryBase<long, User>
    {
        User GetBy(string username);
        List<UserViewModel> Search(SearchUser search);
    }
}
