using Mvc_E_Commerce.DAL.Managments;
using Mvc_E_Commerce.Entity.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mvc_E_Commerce.BLL.Controller
{
    public class BasketController
    {
        private BasketManagment basketManagment;

        public BasketController()
        {
            basketManagment = new BasketManagment();
        }

        public Basket AddBasket(Basket Basket)
        {
            Basket addedBasket = null;

            if (Basket == null)
                return null;

            if (Basket.UserId==0 && Basket.ProductId==0)
                return null;

            addedBasket = basketManagment.AddBasket(Basket);
            basketManagment.BasketChangeSave();
            return addedBasket;
        }
        public void UpdateBasket(Basket Basket, Basket yeniBasket)
        {
            if (Basket != null && yeniBasket != null)
            {
                basketManagment.UpdateBasket(Basket);
                basketManagment.ChangeBasket(Basket, yeniBasket);
                basketManagment.BasketChangeSave();
            }
        }
        public void DeleteBasket(Basket Basket)
        {
            if (Basket != null)
            {
                basketManagment.DeleteBasket(Basket);
                basketManagment.BasketChangeSave();
            }
        }
        public List<Basket> GetBaskets()
        {
            return basketManagment.GetBasket();
        }
        public Basket GetBasketById(int BasketId)
        {
            if (BasketId == 0)
            {
                return null;
            }
            else
            {
                return basketManagment.GetBasketById(BasketId);
            }
        }
    }
}
