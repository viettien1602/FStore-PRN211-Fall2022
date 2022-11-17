using DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository
{
    public interface IOrderRepository
    {
        List<Order> GetOrders();
        List<Object> ReportOrders();
        List<Object> ReportOrdersByDate(DateTime startTime, DateTime endTime);
        Order AddOrder(Order order);
    }
}
