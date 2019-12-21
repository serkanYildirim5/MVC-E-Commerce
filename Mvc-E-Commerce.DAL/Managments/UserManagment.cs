using Mvc_E_Commerce.Entity.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mvc_E_Commerce.DAL.Managments
{
    public class UserManagment
    {
        private Mvc_E_CommerceContext database;

        public UserManagment()
        {
            database = new Mvc_E_CommerceContext();
        }

        public User AddUser(User user)
        {
            return database.Set<User>().Add(user);
        }

        public void UpdateUser(User user)
        {
            database.Entry(user).State = EntityState.Modified;
        }

        public void DeleteUser(User user)
        {
            database.Set<User>().Remove(user);
        }

        public void ChangeUser(User eskiUser, User yeniUser)
        {
            database.Entry(eskiUser).CurrentValues.SetValues(yeniUser);
        }

        public List<User> GetUsers()
        {
            return database.Set<User>().ToList();
        }

        public User GetUserById(int userId)
        {          
            return database.Set<User>().FirstOrDefault(u => u.UserId == userId);
        }

        public int UserChangeSave()
        {
            return database.SaveChanges();
        }

    }
}

