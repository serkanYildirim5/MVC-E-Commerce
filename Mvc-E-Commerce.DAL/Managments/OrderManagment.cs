using Mvc_E_Commerce.Entity.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mvc_E_Commerce.DAL.Managments
{
    public class OrderManagment
    {
        private Mvc_E_CommerceContext database;

        public OrderManagment()
        {
            database = new Mvc_E_CommerceContext();
        }

        public Order AddOrder(Order Order)
        {
            return database.Set<Order>().Add(Order);
        }

        public void UpdateOrder(Order Order)
        {
            database.Entry(Order).State = EntityState.Modified;
        }

        public void DeleteOrder(Order Order)
        {
            database.Set<Order>().Remove(Order);
        }

        public void ChangeOrder(Order eskiOrder, Order yeniOrder)
        {
            database.Entry(eskiOrder).CurrentValues.SetValues(yeniOrder);
        }

        public List<Order> GetOrder()
        {
            return database.Set<Order>().ToList();
        }

        public Order GetOrderById(int OrderId)
        {
            return database.Set<Order>().FirstOrDefault(u => u.OrderId == OrderId);
        }

        public int OrderChangeSave()
        {
            return database.SaveChanges();
        }
    }
}
