using Prueba.Domain.Entitites;
using Prueba.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Prueba.Persistence.Repositories
{
    public class ProductRepository : IProductRepository
    {
        private List<Product> products;

        public ProductRepository()
        {
            products = new List<Product>
            {
                new Product { Id = 0, Description = "Leche", Price = 5.67},
                new Product { Id = 1, Description = "Berenjena", Price = 4},
                new Product { Id = 2, Description = "Jugo", Price = 5},
                new Product { Id = 3, Description = "Plato", Price = 10},
                new Product { Id = 3, Description = "Vaso", Price = 9.99},
                new Product { Id = 3, Description = "Plato", Price = 10},
                new Product { Id = 3, Description = "Lapiz", Price = 3.76},

            };
        }
        public IEnumerable<Product> ListAsync()
        {
            return this.products;
        }
    }
}
