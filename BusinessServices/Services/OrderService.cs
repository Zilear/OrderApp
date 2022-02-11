using BusinessObject.Model;
using BusinessObject.Repositories.Interfaces;
using BusinessServices.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessServices.Services
{
    public class OrderService : IOrderService
    {
        private readonly IOrderRepository _orderRepository;
        public OrderService(IOrderRepository orderRepository)
        {
            _orderRepository = orderRepository;
        }
        public Task<bool> Create(Order order)
        {
            return _orderRepository.Create(order);
        }

        public Task<bool> Delete(Order order)
        {
            return _orderRepository.Delete(order);
        }

        public Task<ActionResult<IEnumerable<Order>>> GetAll()
        {
            return _orderRepository.GetAll();
        }

        public Task<bool> Update(Order order)
        {
            return _orderRepository.Update(order);
        }
    }
}
