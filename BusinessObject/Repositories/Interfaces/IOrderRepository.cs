using BusinessObject.Model;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessObject.Repositories.Interfaces
{
    public interface IOrderRepository
    {
        public Task<bool> Create(Order order); 
        public Task<ActionResult<IEnumerable<Order>>> GetAll();
        public Task<bool> Update(Order order);
        public Task<bool> Delete(Order order);

    }
}
