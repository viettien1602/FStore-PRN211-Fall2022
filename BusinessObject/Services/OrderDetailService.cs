using DataAccess.Models;
using DataAccess.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessObject.Services
{
    public class OrderDetailService
    {
        private OrderDetailRepository orderDetailRepository;

        public OrderDetailService()
        {
            orderDetailRepository = new();
        }

        public List<OrderDetail> GetOrderDetails() => orderDetailRepository.GetOrderDetails();

        public void Add(OrderDetail orderDetail) => orderDetailRepository.Add(orderDetail);
    }
}
