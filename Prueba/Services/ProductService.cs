using Prueba.Domain.Entitites;
using Prueba.Domain.Repositories;
using Prueba.Domain.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Prueba.Services
{
    public class ProductService : IProductService
    {
        private readonly IProductRepository _productRepository;

        public ProductService(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }
        public IEnumerable<Product> ListAsync()
        {
            return _productRepository.ListAsync();
        }
    }
}
