using Mvc_E_Commerce.DAL.Managments;
using Mvc_E_Commerce.Entity.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mvc_E_Commerce.BLL.Controller
{
    public class UserController
    {
        private UserManagment userManagment;

        public UserController()
        {
            userManagment = new UserManagment();
        }

        public User AddUser(User user)
        {
            User addedUser = null;

            if (user == null)
                return null;

            if (user.FirstName.Length>40)
                return null;

            addedUser = userManagment.AddUser(user);
            userManagment.UserChangeSave();
            return addedUser;
        }
        public void UpdateUser(User user,User yeniUser)
        {
            if (user != null && yeniUser!=null)
            {
                userManagment.UpdateUser(user);
                userManagment.ChangeUser(user,yeniUser);
                userManagment.UserChangeSave();
            }
        }
        public void DeleteUser(User user)
        {
            if (user != null)
            {
                userManagment.DeleteUser(user);
                userManagment.UserChangeSave();
            }
        }
        public List<User> GetUsers()
        {
            return userManagment.GetUsers(); 
        }
        public User GetUserById(int userId)
        {
            if (userId == 0)
            {
                return null;
            }
            else
            {
                return userManagment.GetUserById(userId);
            }
        }


    }      
}
