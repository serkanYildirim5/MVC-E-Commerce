
using Mvc_E_Commerce.Entity.DTO;
using Mvc_E_Commerce.Entity.IdentityModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mvc_E_Commerce.Helpers.Extensions
{
    public static class RegisterExtensions
    {

        public static User GetUser(this RegisterDTO registerDTO)
        {
            var newUser = new User()
            {
                UserName = registerDTO.UserName,
                Email = registerDTO.Email,
                Name = registerDTO.Name

            };
            return newUser;
        }

    }
}
