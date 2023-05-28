using _01_Framework.Application;
using System.Collections.Generic;

namespace AccountManagement.Application.Contract.Role
{
    public interface IRoleApplication
    {
        ActionResponse Create(CreateRole command);
        List<RoleViewModel> Search(SearchRole search);
        ActionResponse GetDetails(long id);
    }
}
