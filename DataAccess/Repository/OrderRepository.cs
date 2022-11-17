using DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository
{
    public class OrderRepository : IOrderRepository
    {
        private readonly FStoreDBContext dbContext;

        public OrderRepository()
        {
            dbContext = new FStoreDBContext();
        }
        public List<Order> GetOrders() => dbContext.Orders.ToList();

        public Order AddOrder(Order order)
        {
            Order returnOrder = null;
            if (order is not null)
            {
                returnOrder = dbContext.Add(order).Entity;
                dbContext.SaveChanges();
            }
            return returnOrder;
        }
    }
}
