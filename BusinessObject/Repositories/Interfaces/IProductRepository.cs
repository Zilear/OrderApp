using BusinessObject.Model;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessObject.Repositories.Interfaces
{
    public interface IProductRepository
    {
        public Task<bool> Create(Product product);
        public Task<ActionResult<IEnumerable<Product>>> GetAll();
        public Task<bool> Update(Product product);
        public Task<bool> Delete(Product product);
    }
}
