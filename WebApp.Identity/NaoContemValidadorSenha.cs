using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApp.Identity
{
    public class NaoContemValidadorSenha<TUser> : IPasswordValidator<TUser> where TUser : class
    {
        public async Task<IdentityResult> ValidateAsync(UserManager<TUser> manager, TUser user, string password)
        {
            var username = await manager.GetUserNameAsync(user);

            if (username == password)
                return IdentityResult.Failed(
                    new IdentityError { Description = "A senha não pode ser igual ao Password" }
                );
            if (password.Contains("password"))
                return IdentityResult.Failed(
                    new IdentityError { Description = "A senha não pode ser Password" }
                );

            return IdentityResult.Success;
        }
    }
}
