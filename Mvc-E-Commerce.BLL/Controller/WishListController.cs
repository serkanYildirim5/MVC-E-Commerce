using Mvc_E_Commerce.DAL.Managments;
using Mvc_E_Commerce.Entity.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mvc_E_Commerce.BLL.Controller
{
    public class WishListController
    {
        private WishListManagment WishListManagment;

        public WishListController()
        {
            WishListManagment = new WishListManagment();
        }

        public WishList AddWishList(WishList WishList)
        {
            WishList addedWishList = null;

            if (WishList == null)
                return null;

            if (WishList.UserID==0 && WishList.ProductID==0)
                return null;

            addedWishList = WishListManagment.AddWishList(WishList);
            WishListManagment.WishListChangeSave();
            return addedWishList;
        }
        public void UpdateWishList(WishList WishList, WishList yeniWishList)
        {
            if (WishList != null && yeniWishList != null)
            {

                WishListManagment.ChangeWishList(WishList, yeniWishList);
                WishListManagment.WishListChangeSave();
            }
        }
        public void DeleteWishList(WishList WishList)
        {
            if (WishList != null)
            {
                WishListManagment.DeleteWishList(WishList);
                WishListManagment.WishListChangeSave();
            }
        }
        public List<WishList> GetWishLists()
        {
            return WishListManagment.GetWishList();
        }
        public WishList GetWishListById(int WishListId)
        {
            if (WishListId == 0)
            {
                return null;
            }
            else
            {
                return WishListManagment.GetWishListById(WishListId);
            }
        }
    }
}
