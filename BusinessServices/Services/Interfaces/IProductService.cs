using BusinessObject.Model;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessServices.Services.Interfaces
{
    public interface IProductService
    {
        public Task<bool> Create(Product product);
        public Task<ActionResult<IEnumerable<Product>>> GetAll();
        public Task<bool> Update(Product product);
        public Task<bool> Delete(Product product);
    }
}
