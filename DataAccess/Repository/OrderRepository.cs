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
        public List<Order> GetOrders() => _dbContext.Orders.ToList();

        public List<object> ReportOrders()
        {//count, sum, orderdate
            List<object> orders = new List<object>();
            var rs = from o in _dbContext.Orders
                     join od in _dbContext.OrderDetails on o.OrderId equals od.OrderId
                     select new
                     {
                         OrderDate = o.OrderDate,
                         OrderID = o.OrderId,
                         Freight = o.Freight,
                         Quantity = od.Quantity,
                         UnitPrice = od.UnitPrice,
                         Discount = od.Discount,
                         Total = (decimal)(od.Quantity * (int)od.UnitPrice * (1 - od.Discount))
                     };
            var rrrs = rs.GroupBy(o => o.OrderID)
                .Select(m => new
                {
                    OrderDate = m.First().OrderDate,
                    Total = m.First().Freight + m.Sum(t => t.Total)
                }).ToList();
            var rrs = rrrs.GroupBy(o => o.OrderDate.Date)
                .Select(m => new
                {
                    OrderDate = m.First().OrderDate.Date,
                    QuantityOrder = m.Count(),
                    Total = m.Sum(t => t.Total)
                }).OrderByDescending(o => o.OrderDate).ToList();
            foreach (var r in rrs)
                orders.Add(r);
            return orders;
        }

        public List<object> ReportOrdersByDate(DateTime startTime, DateTime endTime)
        {
            List<object> orders = new List<object>();
            var rs = from o in _dbContext.Orders
                     join od in _dbContext.OrderDetails on o.OrderId equals od.OrderId
                     select new
                     {
                         OrderDate = o.OrderDate,
                         OrderID = o.OrderId,
                         Freight = o.Freight,
                         Quantity = od.Quantity,
                         UnitPrice = od.UnitPrice,
                         Discount = od.Discount,
                         Total = (decimal)(od.Quantity * (int)od.UnitPrice * (1 - od.Discount))
                     };
            var rrrs = rs.GroupBy(o => o.OrderID)
                .Select(m => new
                {
                    OrderDate = m.First().OrderDate,
                    Total = m.First().Freight + m.Sum(t => t.Total)
                }).ToList();
            var rrs = rrrs.GroupBy(o => o.OrderDate.Date)
                .Select(m => new
                {
                    OrderDate = m.First().OrderDate.Date,
                    QuantityOrder = m.Count(),
                    Total = m.Sum(t => t.Total)
                }).OrderByDescending(o => o.OrderDate).ToList();
            if (startTime != null && endTime != null)
                rrs = rrs.Where(o => o.OrderDate >= startTime && o.OrderDate <= endTime).ToList();
            foreach (var r in rrs)
                orders.Add(r);
            return orders;
        }

        public Order AddOrder(Order order)
        {
            Order returnOrder = null;
            if (order is not null)
            {
                returnOrder = _dbContext.Add(order).Entity;
                _dbContext.SaveChanges();
            }
            return returnOrder;
        }
    }
}
