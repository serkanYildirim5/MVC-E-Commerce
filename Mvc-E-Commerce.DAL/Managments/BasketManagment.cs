using Mvc_E_Commerce.Entity.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mvc_E_Commerce.DAL.Managments
{
    public class BasketManagment
    {
        private Mvc_E_CommerceContext database;

        public BasketManagment()
        {
            database = new Mvc_E_CommerceContext();
        }

        public Basket AddBasket(Basket Basket)
        {
            return database.Set<Basket>().Add(Basket);
        }

        public void UpdateBasket(Basket Basket)
        {
            database.Entry(Basket).State = EntityState.Modified;
        }

        public void DeleteBasket(Basket Basket)
        {
            database.Set<Basket>().Remove(Basket);
        }

        public void ChangeBasket(Basket eskiBasket, Basket yeniBasket)
        {
            database.Entry(eskiBasket).CurrentValues.SetValues(yeniBasket);
        }

        public List<Basket> GetBasket()
        {
            return database.Set<Basket>().ToList();
        }

        public Basket GetBasketById(int BasketId)
        {
            return database.Set<Basket>().FirstOrDefault(u => u.BasketId == BasketId);
        }

        public int BasketChangeSave()
        {
            return database.SaveChanges();
        }

    }
}
