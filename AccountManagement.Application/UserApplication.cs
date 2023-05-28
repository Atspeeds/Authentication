using _0_FrameWork.Application;
using _01_Framework.Application;
using AccountManagement.Application.Contract.User;
using AccountManagement.Domain.UserAgg;
using System;
using System.Collections.Generic;
using System.Security;

namespace AccountManagement.Application
{
    public class UserApplication : IUserApplication
    {
        private readonly IUserRepository _userRepository;
        private readonly IPasswordHasher _passwordHasher;
        private readonly IAuthHelper _authHelper;
        public UserApplication(IUserRepository userRepository, IPasswordHasher passwordHasher, IAuthHelper authHelper)
        {
            _userRepository = userRepository;
            _passwordHasher = passwordHasher;
            _authHelper = authHelper;
        }

        public ActionResponse Create(CreateUser command)
        {
            ActionResponse response = new ActionResponse();

            if (_userRepository.Exists(x => x.UserName == command.UserName))
                return response.Failed(ServiceMessage.DuplicateRecord);

            var passwoard = _passwordHasher.Hash(command.Passwoard);

            var user = new User(command.FullName, command.UserName, command.Passwoard);

            _userRepository.Create(user);
            _userRepository.Save();

            return response.Success();

        }

        public ActionResponse Login(LoginViewModel command)
        {
            ActionResponse response = new ActionResponse();

            var user = _userRepository.GetBy(command.UserName);

            if (user is null) return response.Failed(ServiceMessage.NoRecordFound);

            var (Verified, NeedsUpgrade) = _passwordHasher.Check(user.Password,command.Password);

            if(!Verified)
                return response.Failed(ServiceMessage.NoRecordFound);

            _authHelper.Signin(new AuthViewModel(user.Id, user.FullName, user.UserName, user.Status));

            return response.Success();

        }

        public List<UserViewModel> Search(SearchUser search)
        {
            return _userRepository.Search(search);
        }
    }
}
