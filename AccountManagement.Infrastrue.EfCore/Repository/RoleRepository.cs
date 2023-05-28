using _01_Framework.Infrastrue;
using AccountManagement.Application.Contract.Role;
using AccountManagement.Domain.RoleAgg;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace AccountManagement.Infrastrue.EfCore.Repository
{
    public class RoleRepository :RepositoryBase<long,Role>, IRoleRepository
    {

        private readonly AccountContext _accountContext;

        public RoleRepository(AccountContext accountContext):base(accountContext)
        {
            _accountContext = accountContext;
        }

        public List<RoleViewModel> Search(SearchRole search)
        {
            throw new NotImplementedException();
        }
    }
}
