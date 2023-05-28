using _01_Framework.Application;
using AccountManagement.Application.Contract.Role;
using AccountManagement.Domain.RoleAgg;
using System;
using System.Collections.Generic;

namespace AccountManagement.Application
{
    public class RoleApplication : IRoleApplication
    {

        private readonly IRoleRepository _roleRepository;

        public RoleApplication(IRoleRepository roleRepository)
        {
            _roleRepository = roleRepository;
        }

        public ActionResponse Create(CreateRole command)
        {
            ActionResponse response = new ActionResponse();

            if (_roleRepository.Exists(x => x.Name == command.Name))
                return response.Failed(ServiceMessage.DuplicateRecord);


            var role = new Role(command.Name, new List<Permission>());

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
            throw new NotImplementedException();
        }
    }
}
