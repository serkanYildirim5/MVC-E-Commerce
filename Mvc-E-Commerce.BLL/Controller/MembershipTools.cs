using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using Mvc_E_Commerce.DAL;
using Mvc_E_Commerce.Entity.IdentityModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace Mvc_E_Commerce.BLL.Controller
{
    public static class MembershipTools
    {
        private static Mvc_E_CommerceContext _db;
        public static UserStore<User> NewUserStore()=>new UserStore<User>(_db ?? new Mvc_E_CommerceContext());
        public static UserManager<User> NewUserManager()
        {
            return new UserManager<User>(NewUserStore());
        }
        public static RoleStore<Role> NewRoleStore() => new RoleStore<Role>(_db ?? new Mvc_E_CommerceContext());
        public static RoleManager<Role> NewRoleManager()
        {
            return new RoleManager<Role>(NewRoleStore());
        }

        public static string GetName(string userId)
        {
            User user;
            if (string.IsNullOrEmpty(userId))
            {
              var id= HttpContext.Current.User.Identity.GetUserId();
                if (string.IsNullOrEmpty(id))
                {
                    return "";
                }
              user= NewUserManager().FindById(id);
            }
            else
            {
                user= NewUserManager().FindById(userId);
                if (user==null)
                {
                    return null;
                }
            }
            return $"{user.Name}";
        }
    }
}
