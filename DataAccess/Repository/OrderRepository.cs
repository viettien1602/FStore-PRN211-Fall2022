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
        private readonly FStoreDBContext _dbContext;

        public OrderRepository()
        {
            _dbContext = new FStoreDBContext();
        }
        /*
        public List<object> GetOrders()
        {
            List<object> results = new List<object>();
            var r = from o in _dbContext.Orders
                    join od in _dbContext.OrderDetails on o.OrderId equals od.OrderId
                    select new { o.OrderId, o.MemberId, o.RequiredDate, o., o. }
        }
        */
    }
}
