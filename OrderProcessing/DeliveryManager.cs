using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderProcessing
{
    public class DeliveryManager:Manager
    {
        /*List<Order> orders = new List<Order>();

        public List<Order> Orders { }
        public void Insert(Order order) { }
        public void Update(Order order) { }
        public void Delete(Order order) { }
        public List<Order> GetAll() { }
        public Order GetOrderByID(int orderId) { }
        public List<Order> GetByVendor(string vendor) { }
        */

        List<Order> orders = new List<Order>();   //List Object Created

        public List<Order> Orders
        {
            get { return orders; }
            set { orders = value; }
        }
        public void Insert(Order order)
        {
            orders.Add(order);
        }
        public void Update(Order order)
        {
            foreach (Order ord in this.orders)
            {
                if (ord.OrderID == order.OrderID)
                    orders.Add(order);
            }
        }
        public void Delete(Order order)
        {
            orders.Remove(order);
        }
        public List<Order> GetAll()
        {
            return orders;
        }
        public Order GetOrderByID(int orderId)
        {
            foreach (Order order in this.orders)
            {
                if (order.OrderID == orderId)
                    return order;
            }
            return null;
        }
        public List<Order> GetByVendor(string vendor)
        {
            List<Order> orders = new List<Order>();
            foreach (WorkOrder order in this.orders)
            {
                if (order.Vendor == vendor)
                    return orders;
            }
            return null;
        }
    }
}
