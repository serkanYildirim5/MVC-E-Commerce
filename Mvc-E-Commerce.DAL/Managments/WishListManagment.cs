using Mvc_E_Commerce.Entity.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mvc_E_Commerce.DAL.Managments
{
    public class WishListManagment
    {
        private Mvc_E_CommerceContext database;

        public WishListManagment()
        {
            database = new Mvc_E_CommerceContext();
        }

        public WishList AddWishList(WishList WishList)
        {
            return database.Set<WishList>().Add(WishList);
        }

        public void UpdateWishList(WishList WishList)
        {
            database.Entry(WishList).State = EntityState.Modified;
        }

        public void DeleteWishList(WishList WishList)
        {
            database.Set<WishList>().Remove(WishList);
        }

        public void ChangeWishList(WishList eskiWishList, WishList yeniWishList)
        {
            database.Entry(eskiWishList).CurrentValues.SetValues(yeniWishList);
        }

        public List<WishList> GetWishList()
        {
            return database.Set<WishList>().ToList();
        }

        public WishList GetWishListById(int WishListId)
        {
            return database.Set<WishList>().FirstOrDefault(u => u.WishListID == WishListId);
        }

        public int WishListChangeSave()
        {
            return database.SaveChanges();
        }
    }
}
