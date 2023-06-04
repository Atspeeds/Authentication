using _01_Framework.Infrastrue;
using AccountManagement.Application.Contract.Role;
using AccountManagement.Domain.RoleAgg;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;

namespace AccountManagement.Infrastrue.EfCore.Repository
{
    public class RoleRepository : RepositoryBase<long, Role>, IRoleRepository
    {

        private readonly AccountContext _accountContext;

        public RoleRepository(AccountContext accountContext) : base(accountContext)
        {
            _accountContext = accountContext;
        }

        public List<RoleViewModel> Search(SearchRole search)
        {
            var query = _accountContext.Roles.Include(p => p.Permissions)
                .Select(r => new RoleViewModel()
                {
                    Id = r.Id,
                    Name = r.Name,
                    CurrentPermissions = MapPermissionCurent(r.Permissions),
                });



            if (!string.IsNullOrWhiteSpace(search.Name))
                query = query.Where(x => x.Name.Contains(search.Name));


            var role = query.AsNoTracking().OrderByDescending(x => x.Id).ToList();


            return role;


        }

        private static List<string> MapPermissionCurent(List<Permission> permissions)
        {
            List<string> Access = new List<string>();

            var resualt = permissions.Select(x => x.Access).ToList();

            foreach (var item in resualt)
            {
                var deserializeAccess = JsonConvert.DeserializeObject<List<string>>(item);

                foreach (var itemlist in deserializeAccess)
                {
                    Access.Add(itemlist);
                }
            }
            return Access;
        }
    }
}
