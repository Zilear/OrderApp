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
    public class ProductService : IProductService
    {
        private readonly IProductRepository _productRepository;
        public ProductService(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }
        public Task<bool> Create(Product product)
        {
            return _productRepository.Create(product);
        }

        public Task<bool> Delete(Product product)
        {
            return _productRepository.Delete(product);
        }

        public Task<ActionResult<IEnumerable<Product>>> GetAll()
        {
            return _productRepository.GetAll();
        }

        public Task<bool> Update(Product product)
        {
            return _productRepository.Update(product);
        }
    }
}
