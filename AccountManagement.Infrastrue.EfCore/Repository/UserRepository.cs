using _01_Framework.Infrastrue;
using AccountManagement.Application.Contract.User;
using AccountManagement.Domain.UserAgg;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace AccountManagement.Infrastrue.EfCore.Repository
{
    public class UserRepository : RepositoryBase<long, User>, IUserRepository
    {

        private readonly AccountContext _accountContext;

        public UserRepository(AccountContext context) : base(context)
        {
            _accountContext = context;
        }

        public User GetBy(string username)
        {
            return _accountContext.Users.FirstOrDefault(x => x.UserName == username);
        }

        public List<UserViewModel> Search(SearchUser search)
        {
            var query = _accountContext.Users
                .Include(x => x.Role)
                .Select(x => new UserViewModel()
                {
                    Id = x.Id,
                    FullName = x.FullName,
                    UserName = x.UserName,
                    Status = x.Status,
                    Role = x.Role.Name,
                    Roleid = x.RoleId,
                });

            if (!string.IsNullOrWhiteSpace(search.Name))
                query = query.Where(x => x.FullName.Contains(search.Name));

            if (search.RoleId > 0)
                query = query.Where(x => x.Roleid == search.RoleId);

            var resualt = query.AsNoTracking()
                .OrderByDescending(x => x.Id).ToList();


            return resualt;

        }
    }
}
