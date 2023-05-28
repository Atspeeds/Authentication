using _01_Framework.Domain;
using AccountManagement.Application.Contract.Role;
using System.Collections.Generic;

namespace AccountManagement.Domain.RoleAgg
{
    public interface IRoleRepository : IRepositoryBase<long, Role>
    {
        List<RoleViewModel> Search(SearchRole search);
    }
}
