using DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository
{
    public class OrderDetailRepository : IOrderDetailRepository
    {
        private readonly FStoreDBContext dbContext;

        public OrderDetailRepository()
        {
            dbContext = new FStoreDBContext();
        }
        public List<OrderDetail> GetOrderDetails() => dbContext.OrderDetails.ToList();

        public void Add(OrderDetail orderDetail)
        {
            if (orderDetail is not null)
            {
                dbContext.Add(orderDetail);
                dbContext.SaveChanges();
            }
        }
    }
}
