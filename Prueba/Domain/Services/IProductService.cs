using Prueba.Domain.Entitites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Prueba.Domain.Services
{
    public interface IProductService
    {
        IEnumerable<Product> ListAsync();
    }
}
