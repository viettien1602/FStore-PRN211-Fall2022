using DataAccess.Models;
using DataAccess.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessObject.Services
{
    public class OrderService
    {
        private OrderRepository orderRepository;

        public OrderService()
        {
            orderRepository = new OrderRepository();
        }

        public List<Order> GetOrders() => orderRepository.GetOrders();
        public List<Object> ReportOrders() => orderRepository.ReportOrders();
        public List<Object> ReportOrdersByDate(DateTime startTime, DateTime endTime) => orderRepository.ReportOrdersByDate(startTime, endTime);

    }
}
