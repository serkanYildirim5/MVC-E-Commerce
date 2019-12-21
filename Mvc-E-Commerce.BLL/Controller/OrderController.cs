using Mvc_E_Commerce.DAL.Managments;
using Mvc_E_Commerce.Entity.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mvc_E_Commerce.BLL.Controller
{
    public class OrderController
    {
        private OrderManagment OrderManagment;

        public OrderController()
        {
            OrderManagment = new OrderManagment();
        }

        public Order AddOrder(Order Order)
        {
            Order addedOrder = null;

            if (Order == null)
                return null;

            if (Order.UserId==0 && Order.StatusId==0)
                return null;

            addedOrder = OrderManagment.AddOrder(Order);
            OrderManagment.OrderChangeSave();
            return addedOrder;
        }
        public void UpdateOrder(Order Order, Order yeniOrder)
        {
            if (Order != null && yeniOrder != null)
            {
                OrderManagment.UpdateOrder(Order);
                OrderManagment.ChangeOrder(Order, yeniOrder);
                OrderManagment.OrderChangeSave();
            }
        }
        public void DeleteOrder(Order Order)
        {
            if (Order != null)
            {
                OrderManagment.DeleteOrder(Order);
                OrderManagment.OrderChangeSave();
            }
        }
        public List<Order> GetOrders()
        {
            return OrderManagment.GetOrder();
        }
        public Order GetOrderById(int OrderId)
        {
            if (OrderId == 0)
            {
                return null;
            }
            else
            {
                return OrderManagment.GetOrderById(OrderId);
            }
        }
    }
}
