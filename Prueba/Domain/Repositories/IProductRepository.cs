using Prueba.Domain.Entitites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Prueba.Domain.Repositories
{
    public interface IProductRepository
    {
        IEnumerable<Product> ListAsync();
    }
}
