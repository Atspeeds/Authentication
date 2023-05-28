using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Security.Claims;

namespace _01_Framework.Application
{
    public class AuthHelper : IAuthHelper
    {

        private readonly IHttpContextAccessor _httpContextAccessor;

        public AuthHelper(IHttpContextAccessor httpContextAccessor)
        {
            _httpContextAccessor = httpContextAccessor;
        }

        public bool Signin(AuthViewModel command)
        {
            var clamims = new List<Claim>
            {
                new Claim("UserId",command.Id.ToString()),
                new Claim(ClaimTypes.Name,command.FullName),
                new Claim("UserName",command.UserName),
                new Claim("Status",command.Status.ToString())
            };

            var claimsIdentity = new ClaimsIdentity(clamims, CookieAuthenticationDefaults.AuthenticationScheme);

            var authProperties = new AuthenticationProperties
            {
                ExpiresUtc = DateTimeOffset.UtcNow.AddDays(30)
            };

            _httpContextAccessor.HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme,
                new ClaimsPrincipal(claimsIdentity), authProperties);

            return true;

        }
    }
}
