using _01_Framework.Application;
using AccountManagement.Application.Contract.Role;
using AccountManagement.Domain.RoleAgg;
using System;
using System.Collections.Generic;
using System.Security.Permissions;

namespace AccountManagement.Application
{
    public class RoleApplication : IRoleApplication
    {

        private readonly IRoleRepository _roleRepository;

        private readonly NamePermissions _namePermissions;

        public RoleApplication(IRoleRepository roleRepository,NamePermissions namePermissions)
        {
            _roleRepository = roleRepository;
            _namePermissions = namePermissions;
        }

        public ActionResponse Create(CreateRole command)
        {
            ActionResponse response = new ActionResponse();

            if (_roleRepository.Exists(x => x.Name == command.Name))
                return response.Failed(ServiceMessage.DuplicateRecord);

            var PermissionsName = _namePermissions.GetAcces(command.permissions);

            var permission=new List<Permission>();

            foreach (var item in command.permissions)
            {
                permission.Add(new Permission(PermissionsName,item));
            }


            var role = new Role(command.Name, permission);

            _roleRepository.Create(role);

            _roleRepository.Save();

            return response.Success();

        }

        public ActionResponse GetDetails(long id)
        {
            throw new NotImplementedException();
        }

        public List<RoleViewModel> Search(SearchRole search)
        {
            return _roleRepository.Search(search);
        }
    }
}
